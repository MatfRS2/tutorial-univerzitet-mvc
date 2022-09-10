using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moj_Univerzitet.Models
{
    public class Student
    {
        public Guid ID { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public DateTime DatumPolaganja { get; set; }

        public ICollection<Polaganje> Polaganja { get; set; }
    }
}
