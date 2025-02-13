 public class Login
    {
        public string password { get; set; }
        public string username { get; set; }
        public string confermaPassword { get; set; }
        public bool esiste {  get; set; }
        public DateTime DateTime { get; set; }
        public void Start()
        {

            Console.WriteLine("===============OPERAZIONI==============");

            Console.WriteLine("\n Scegli l'operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica ora e data di login");
            Console.WriteLine("4.: Lista degli accessi");
            Console.WriteLine("5.: Esci");
            Console.WriteLine("========================================");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1: LoginAcc();
                    break;
                case 2: Logout();
                    break;
                case 3: Orario();
                    break;
                case 4: Accessi();
                    break;
                case 5:Console.WriteLine("Chiusura del programma...");
                    break;
                default: Console.WriteLine("Voce selezionata non valida");
                    Start();
                    break;
            }
        }
        
        private void LoginAcc()
        {
            Console.WriteLine("Inserire un Username");
            string User = Console.ReadLine();
            username = User;
            Console.WriteLine("Scegliere una password");
            string Password = Console.ReadLine();
            password = Password;
            Console.WriteLine("Conferma la password");
            string ConfermaPassword= Console.ReadLine();
            confermaPassword = ConfermaPassword;
            if (confermaPassword == password)
            {
                Console.WriteLine("Account creato con successo");
                DateTime= DateTime.Now;
                esiste=true;
                Start();
            } else
            {
                Console.WriteLine("Errore durante la verifica dei dati, riprovare");
                Start();
            }

        }

        private void Logout()
        {
            if (esiste)
            {
                Console.WriteLine("Sei sicuro di voler uscire? Y/N");
                string risposta = Console.ReadLine();
                if(risposta.ToLower() == "y")
                {
                    Console.WriteLine("Logout in corso...");
                    esiste = false;
                    Console.WriteLine("Logout effettuato");
                    Start() ;
                }
                else
                {
                    Console.WriteLine("Logout annullato");
                    Start();
                }
            }else
            {
                Console.WriteLine("Effettuare prima il login");
                Start() ;
            }
            
        }

        private void Orario()
        {
            if (esiste)
            {
                Console.WriteLine($"l'orario in cui hai creato l'account è il seguente: {DateTime}");
                Start();
            }
            else
            {
                Console.WriteLine("Effettuare prima il login");
                Start();
            }
        }

        private void Accessi()
        {
            if (esiste)
            {
                Console.WriteLine("Ancora da implementare");
                Start();
            }
            else
            {
                Console.WriteLine("Effettuare prima il login");
                Start();
            }
        }
    }

