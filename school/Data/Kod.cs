using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace varren.Data
{
    public class Kod
    {
        public int Id { get; set; }

        public string Kursnamn { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public string Skapare { get; set; }

        public string Lang { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public string Syfte { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public string Data { get; set; }
    }
}
