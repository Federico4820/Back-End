using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimoEsercizio
{
    public class Animale
    {
        public string? Name { get; set; }
        public string? Race { get; set; }
        public int? Age { get; set; }

        public void ShowData()
        {
            Console.WriteLine("Il lupacchiotto è di " + Age + " anni");
        }
    };
}
