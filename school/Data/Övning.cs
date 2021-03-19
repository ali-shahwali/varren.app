using System.ComponentModel.DataAnnotations;

namespace varren.Data
{
    public class Övning
    {
        public int Id { get; set; }
        public string Kursnamn { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public string Ämne { get; set; }

        public string Data { get; set; }
    }
}
