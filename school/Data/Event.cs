using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Data
{
    public class Event
    {
        public int Id { get; set; }

        public DateTime? Datum { get; set; }

        public TimeSpan? Time { get; set; }

        public int Week { get; set; }

        public string ToDo { get; set; }

        public string Type { get; set; }

        public bool IsDone { get; set; }
    }
}
