using static System.Runtime.InteropServices.JavaScript.JSType;

namespace S2L1.Models
{
    class Menù
    {
        public double totale { get; set; } = 3.00;
        public DateTime DateTime { get; set; }

        List<string> ordini = new List<string> {};
        public void Start()
        {

            Console.WriteLine("==============MENU==============");

            Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2: Insalata di pollo (€ 5.20)");
            Console.WriteLine("3: Pizza Margherita (€ 10.00)");
            Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6: Insalata di riso (€ 8.00)");
            Console.WriteLine("7: Frutta di stagione (€ 5.00)");
            Console.WriteLine("8: Pizza fritta (€ 5.00)");
            Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10: Panino Hamburger (€ 7.90)");
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");

            Console.WriteLine("Seleziona i cibi digitando il numero per ogni piatto, inserire un numero per volta premendo invio");

        seleziona:

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    ordini.Add("Coca Cola 150 ml");
                    totale += 2.50;
                    goto seleziona;
                    
                case 2:
                    ordini.Add("Insalata di pollo");
                    totale += 5.20;
                    goto seleziona;
                    
                case 3:
                    ordini.Add("Pizza Margherita");
                    totale += 10.00;
                        goto seleziona;
                    
                case 4:
                    ordini.Add("Pizza 4 Formaggi");
                    totale += 12.50;
                    goto seleziona;
                    
                case 5:
                    ordini.Add("Pz patatine fritte");
                    totale += 3.50;
                    goto seleziona;
                    
                case 6:
                    ordini.Add("Insalata di riso");
                    totale += 8.00;
                    goto seleziona;
                    
                case 7:
                    ordini.Add("Frutta di stagione");
                    totale += 5.00;
                    goto seleziona;
                    
                case 8:
                    ordini.Add("Pizza fritta");
                    totale += 5.00;
                    goto seleziona;
                    
                case 9:
                    ordini.Add("Piadina vegetariana");
                    totale += 6.00;
                    goto seleziona;
                    
                case 10:
                    ordini.Add("Panino Hamburger");
                    totale += 7.90;
                    goto seleziona;
                    
                case 11:
                    Console.WriteLine($"Il menù è composto da:");
                    foreach (string ordine in ordini)
                    {
                        Console.WriteLine(ordine);
                    }
                    Console.WriteLine($"il totale è:{totale} inclusi i 3 euro di coperto");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Voce selezionata non valida");
                    goto seleziona;
            }
        }
    }
}
