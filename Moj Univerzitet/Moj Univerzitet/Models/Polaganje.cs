using System;

namespace Moj_Univerzitet.Models
{
    public enum Ocena
    {
        OcNijeIzasao = 4, Oc5, Oc6, Oc7, Oc8, Oc9, Oc10
    }

    public class Polaganje
    {
        public Guid PolaganjeId { get; set; }
        public Guid PredmetId { get; set; }
        public Guid StudentId { get; set; }
        public Ocena? Ocena { get; set; }

        public Predmet Predmet { get; set; }
        public Student Student { get; set; }
    }
}
