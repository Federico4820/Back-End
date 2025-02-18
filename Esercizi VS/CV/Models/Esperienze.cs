using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Models
{
    public class Esperienze
    {
        public string? azienda { get; set; }
        public string? jobTitle { get; set; }
        public DateTime dal { get; set; }
        public DateTime al { get; set; }
        public string? descrizione { get; set; }
        public string? compiti { get; set; }
    }
}
