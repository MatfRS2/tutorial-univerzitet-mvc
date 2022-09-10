using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moj_Univerzitet.Models
{
    public class Predmet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Polaganje> Polaganja { get; set; }
    }
}
