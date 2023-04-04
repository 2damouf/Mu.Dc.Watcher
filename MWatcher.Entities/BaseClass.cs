using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWatcher.Entities
{
    public class BaseClass
    {
        public static List<ClientDto> ClientList = new List<ClientDto>();
        public static List<ClientDto> DcList = new List<ClientDto>();
        public static bool HeartBeat;
    }
}
