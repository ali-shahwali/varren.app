using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school.Data
{
    public class Profile
    {
        public int Id { get; set; }

        public string Mail { get; set; }

        public string Name { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}
