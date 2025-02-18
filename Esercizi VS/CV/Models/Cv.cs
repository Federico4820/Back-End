using System;
using System.Collections.Generic;

namespace CV.Models
{
    public class Cv
    {
        public InformazioniPersonali informazioniPersonali = new InformazioniPersonali
        {
            nome = "",
            cognome = "",
            email = "",
            telefono = "",
        };
        public Studi studiEffettuati = new Studi
        {
            tipo = "",
            istututo = "",
            qualifica = "",
            dal = DateTime.Now,
            al = DateTime.Now
        };
        public Impieghi impieghi = new Impieghi
        {
            esperienze= new List<Esperienze>()
        };
    }
    
}
