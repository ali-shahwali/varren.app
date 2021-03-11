using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Data
{
    public class Tentor
    {
        public int Id { get; set; }
        public string Kursnamn { get; set; }
        public DateTime? Datum { get; set; }
        public string Examinator { get; set; }
        public byte[] Data { get; set; }
    }
}
