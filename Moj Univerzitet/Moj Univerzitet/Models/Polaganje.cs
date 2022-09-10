using System;

namespace Moj_Univerzitet.Models
{
    public enum Ocena
    {
        OcNijeIzasao = 4, Oc5, Oc6, Oc7, Oc8, Oc9, Oc10
    }

    public class Polaganje
    {
        public int PolaganjeId { get; set; }
        public int PredmetId { get; set; }
        public int StudentId { get; set; }
        public Ocena? Ocena { get; set; }

        public Predmet Predmet { get; set; }
        public Student Student { get; set; }
    }
}
