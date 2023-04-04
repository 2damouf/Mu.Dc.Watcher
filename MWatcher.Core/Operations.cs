using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;
using MWatcher.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MWatcher.Core
{
    public class Operations
    {
        public Operations()
        {

        }
        public void StartListWatcher()
        {
            Network.NetworkPerformanceReporter.Create();
        }
        public void Run()
        {
            Thread.Sleep(1000);
            foreach (var item in BaseClass.ClientList)
            {
                if (item.OldPackageValue == 0)
                {
                    item.OldPackageValue = item.NewPackageValue;
                }
                else
                {
                    if (DcValueCheck(item.OldPackageValue, item.NewPackageValue))
                    {
                        item.DcCounter += 1;
                        item.CharStatus = SetCharacterStatus(item, item.DcCounter);
                    }
                    else
                    {
                        item.DcCounter = 0;
                        item.OldPackageValue = item.NewPackageValue;
                        item.CharStatus = true;
                    }
                }
            }
        }
        public void SetCharacter(string charName, long clientId, DateTime startDate, bool charStatus, int oldVal = 0, int newVal = 0, int dcCounter = 0)
        {
            ClientDto client = new ClientDto
            {
                CharName = charName,
                ClientId = clientId,
                ClientStartDate = startDate,
                CharStatus = charStatus,
                NewPackageValue = newVal,
                OldPackageValue = oldVal,
                DcCounter = dcCounter
            };
            BaseClass.ClientList.Add(client);
        }
        private bool SetCharacterStatus(ClientDto c, int counter)
        {
            if (counter > 6)
            {
                try
                {
                    Notify.SendNotify($"{c.CharName} dc oldu!", "DC");
                    Notify.SendWpNotify($"{c.CharName} dc oldu!");
                    BaseClass.ClientList.Remove(c);
                    BaseClass.DcList.Add(c);
                    c.ClientDcDate = DateTime.Now;
                }
                catch
                {

                }
                return false;
            }
            return true;
        }
        private bool DcValueCheck(long val1, long val2)
        {
            if (val1 == val2)
            {
                return true;
            }
            return false;
        }
        public async Task SendHeartBeatAsync(int value)
        {
            await Task.Run(async () =>
            {
                while (BaseClass.HeartBeat)
                {
                    TestNotify();
                    await Task.Delay(Convert.ToInt32(value) * 1000);
                }
            });
        }
        public void TestNotify()
        {
            Notify.SendNotify("Test Bildirimi Gönderildi!", "Test");
        }
        public void TestWp()
        {
            Notify.SendWpNotify("Test Mesajı Gönderildi!");
        }
    }
}

