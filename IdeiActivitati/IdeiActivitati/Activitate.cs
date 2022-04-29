using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace IdeiActivitati
{
    [Table("activitati")]
    public class Activitate
    {
        [PrimaryKey]
        [AutoIncrement]
        [JsonProperty("key")]
        public int Id { get; set; }

        [JsonProperty("activity")]
        public string Descriere { get; set; }

        /*[EnumDataType(typeof(TipActivitate))]*/
        [JsonProperty("type")]
        public string Tip { get; set; }

        // tipuri activitati ["education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork"]
        [JsonProperty("participants")]
        public int Participanti { get; set; }

        [JsonProperty("price")]
        public double Cost { get; set; }

        public DateTime Data { get; set; }

        [JsonProperty("link")]
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

        public Activitate() { }
    }
}
