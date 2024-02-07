using FIT.Data.IspitBrojIndeksa;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public List<PolozeniPredmetiBrojIndeksa> polozeni {get; set; }
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public int SemestarId { get; set; }
        public SemestriBrojIndeksa Semestar { get; set; }
        public int GradId { get; set; }
        public GradoviBrojIndeksa Grad { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        [NotMapped]
        public string Prosjek { get
            {
                if (polozeni == null || !polozeni.Any())
                    return "5";
                var prosjek = polozeni.Average(x=>x.Ocjena);
                return prosjek.ToString("0.00");
            }
        }
        [NotMapped]
        public string Drzava => Grad.Drzava.ToString();
    }
}
