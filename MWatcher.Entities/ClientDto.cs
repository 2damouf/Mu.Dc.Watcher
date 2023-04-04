using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWatcher.Entities
{
    public class ClientDto
    {
        public string CharName { get; set; }
        public long ClientId { get; set; }
        public int OldPackageValue { get; set; }
        public int NewPackageValue { get; set; }
        public bool CharStatus { get; set; }
        public int DcCounter { get; set; }
        public DateTime ClientStartDate { get; set; }
        public DateTime? ClientDcDate { get; set; }
    }
}
