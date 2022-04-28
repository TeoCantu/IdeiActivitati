using System;

namespace IdeiActivitati
{
    public class Activitate
    {
        public int Id { get; set; }
        public string Descriere { get; set; }
        public string Tip { get; set; }
        // tipuri activitati ["education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork"]
        public int Participanti { get; set; }
        public double Cost { get; set; }
        public DateTime Data { get; set; }
        public string DetaliiSuplimentare { get; set; }

        public Activitate(int id, string descriere, string tip, int participanti, double cost, DateTime data, string detaliiSuplimentare)
        {
            Id = id;
            Descriere = descriere;
            Tip = tip;
            Participanti = participanti;
            Cost = cost;
            Data = data;
            DetaliiSuplimentare = detaliiSuplimentare;
        }
    }
}
