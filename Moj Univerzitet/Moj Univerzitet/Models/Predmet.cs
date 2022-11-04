using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moj_Univerzitet.Models
{
    public class Predmet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public int BrojKredita { get; set; }

        public ICollection<Polaganje> Polaganja { get; set; }
    }
}
