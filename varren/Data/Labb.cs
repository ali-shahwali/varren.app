using System.ComponentModel.DataAnnotations;


namespace school.Data
{
    public class Labb
    {
        public int Id { get; set; }

        public string Kursnamn { get; set; }

        [Required(ErrorMessage = "Detta fält måste fyllas i.")]
        public string Typ { get; set; }

        public string Data { get; set; }

    }
}
