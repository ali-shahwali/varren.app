using System;
using System.ComponentModel.DataAnnotations;

namespace school.Data
{
    public class Tenta
    {
        public int Id { get; set; }
        public string Kursnamn { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public DateTime? Datum { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public string Examinator { get; set; }

        public string Data { get; set; }
    }
}
