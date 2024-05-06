using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActionMonitor
    {
        public string ActionId { get; set; }
        public string SupervisorId { get; set; }
        public string Actor { get; set; }
        public DateTime Time { get; set; }
        public string ActionDesc { get; set; }
    }
}
