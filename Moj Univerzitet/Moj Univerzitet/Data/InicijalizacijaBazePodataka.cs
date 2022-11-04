using Moj_Univerzitet.Models;
using System;
using System.Linq;

namespace Moj_Univerzitet.Data
{
    public static class InicijalizacijaBazePodataka
    {
        public static void Inicijalizuj(MojUniverzitetKontekst context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Studenti.Any())
            {
                return;   // DB has been seeded
            }

            var studenti = new Student[]
            {
            new Student{Ime="Митар",Prezime="Мирић",DatumPolaganja=DateTime.Parse("2005-09-01")},
            new Student{Ime="Тома",Prezime="Здравковић",DatumPolaganja=DateTime.Parse("2002-09-01")},
            new Student{Ime="Шабан",Prezime="Шаулић",DatumPolaganja=DateTime.Parse("2003-09-01")},
            new Student{Ime="Мирослав",Prezime="Илић",DatumPolaganja=DateTime.Parse("2002-09-01")},
            new Student{Ime="Ипче",Prezime="Ахмедовски",DatumPolaganja=DateTime.Parse("2002-09-01")},
            new Student{Ime="Аца",Prezime="Лукас",DatumPolaganja=DateTime.Parse("2001-09-01")},
            new Student{Ime="Халид",Prezime="Бешлић",DatumPolaganja=DateTime.Parse("2003-09-01")},
            new Student{Ime="Душко",Prezime="Кулиш",DatumPolaganja=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in studenti)
            {
                context.Studenti.Add(s);
            }
            context.SaveChanges();

            var predmeti = new Predmet[]
            {
            new Predmet{PredmetId=1050,Naziv="Математичка Анализа 2",BrojKredita=3},
            new Predmet{PredmetId=4022,Naziv="Увод у веб и интернет технологије",BrojKredita=3},
            new Predmet{PredmetId=4041,Naziv="Објектно орјентисано програмирање",BrojKredita=3},
            new Predmet{PredmetId=1045,Naziv="Линеарна алгебра",BrojKredita=4},
            new Predmet{PredmetId=3141,Naziv="Аналитичка геометрија",BrojKredita=4},
            new Predmet{PredmetId=2021,Naziv="Вероватноћа и статистика",BrojKredita=3},
            new Predmet{PredmetId=2042,Naziv="Рачунарске мреже",BrojKredita=4}
            };
            foreach (Predmet p in predmeti)
            {
                context.Predmeti.Add(p);
            }
            context.SaveChanges();

            var polaganja = new Polaganje[]
            {
            new Polaganje{StudentId=1,PredmetId=1050,Ocena=Ocena.Oc10},
            new Polaganje{StudentId=1,PredmetId=4022,Ocena=Ocena.Oc8},
            new Polaganje{StudentId=1,PredmetId=4041,Ocena=Ocena.Oc9},
            new Polaganje{StudentId=2,PredmetId=1045,Ocena=Ocena.Oc9},
            new Polaganje{StudentId=2,PredmetId=3141,Ocena=Ocena.Oc6},
            new Polaganje{StudentId=2,PredmetId=2021,Ocena=Ocena.Oc6},
            new Polaganje{StudentId=3,PredmetId=1050},
            new Polaganje{StudentId=4,PredmetId=1050},
            new Polaganje{StudentId=4,PredmetId=4022,Ocena=Ocena.Oc6},
            new Polaganje{StudentId=5,PredmetId=4041,Ocena=Ocena.Oc8},
            new Polaganje{StudentId=6,PredmetId=1045},
            new Polaganje{StudentId=7,PredmetId=3141,Ocena=Ocena.Oc10},
            };
            foreach (Polaganje e in polaganja)
            {
                context.Polaganja.Add(e);
            }
            context.SaveChanges();
        }
    }
}
