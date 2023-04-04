using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Session;
using MWatcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MWatcher.Core
{
    internal class Network
    {
        public sealed class NetworkPerformanceReporter : IDisposable
        {
            private DateTime m_EtwStartTime;
            private TraceEventSession traceLogger;

            public readonly Counters m_Counters = new Counters();
            public class Counters
            {
                public long Received;
            }

            private NetworkPerformanceReporter() { }

            public static NetworkPerformanceReporter Create()
            {
                var networkPerformancePresenter = new NetworkPerformanceReporter();
                networkPerformancePresenter.Initialise();
                return networkPerformancePresenter;
            }

            private void Initialise()
            {
                Task.Run(() => Run());
            }
            private void Run()
            {
                try
                {
                    ResetCounters();
                    using (traceLogger = new TraceEventSession("MyKernelAndClrEventsSession"))
                    {
                        traceLogger.EnableKernelProvider(KernelTraceEventParser.Keywords.NetworkTCPIP);
                        traceLogger.Source.Kernel.TcpIpRecv += data =>
                        {
                            foreach (var item in BaseClass.ClientList)
                            {
                                if (data.ProcessID == item.ClientId)
                                {
                                    item.NewPackageValue += data.size;
                                }
                            }
                        };
                        traceLogger.Source.Kernel.TcpIpSend += data =>
                        {
                            foreach (var item in BaseClass.ClientList)
                            {
                                if (data.ProcessID == item.ClientId)
                                {
                                    item.NewPackageValue += data.size;
                                }
                            }
                        };
                        traceLogger.Source.Process();
                    }
                }
                catch
                {
                    ResetCounters();
                }
            }

            public NetworkPerformanceData GetNetworkPerformanceData()
            {
                var timeDifferenceInSeconds = (DateTime.Now - m_EtwStartTime).TotalSeconds;

                NetworkPerformanceData networkData;

                lock (m_Counters)
                {
                    networkData = new NetworkPerformanceData
                    {
                        BytesReceived = Convert.ToInt64(m_Counters.Received / timeDifferenceInSeconds),
                    };

                }
                ResetCounters();

                return networkData;
            }

            private void ResetCounters()
            {
                lock (m_Counters)
                {
                    m_Counters.Received = 0;
                }
                m_EtwStartTime = DateTime.Now;
            }

            public void Dispose()
            {
                traceLogger?.Dispose();
            }
        }

        public sealed class NetworkPerformanceData
        {
            public long BytesReceived { get; set; }
            public long BytesSent { get; set; }
        }



    }
}
