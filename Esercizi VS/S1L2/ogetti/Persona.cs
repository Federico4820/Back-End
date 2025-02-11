using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1L2.ogetti
{
    public class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public int? Età { get; set; }

        public void MostraPersona()
        {
            Console.WriteLine("Ciao mi chiamo " + Nome + " " + Cognome + " ed ho " + Età + " anni");
        }
    }

}
