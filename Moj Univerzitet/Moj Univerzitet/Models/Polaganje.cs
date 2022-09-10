using System;

namespace Moj_Univerzitet.Models
{
    public enum Ocena
    {
        Oc5=5, Oc6, Oc7, Oc8, Oc9, Oc10
    }

    public class Polaganje
    {
        public Guid PolaganjeID { get; set; }
        public Guid PredmetID { get; set; }
        public Guid StudentID { get; set; }
        public Ocena? Ocena { get; set; }

        public Predmet Predmet { get; set; }
        public Student Student { get; set; }
    }
}
