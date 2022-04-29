using System;
using System.Collections.Generic;
using System.Text;

namespace IdeiActivitati
{
    public class Sugestie
    {
        public string Denumire { get; set; }
        public string Imagine { get; set; }
        public string Descriere { get; set; }

        public Sugestie(string denumire, string imagine, string descriere)
        {
            Denumire = denumire;
            Imagine = imagine;
            Descriere = descriere;
        }

        public Sugestie(string denumire, string descriere)
        {
            Denumire = denumire;
            Descriere = descriere;
        }

        public Sugestie()
        {
        }
    }
}
