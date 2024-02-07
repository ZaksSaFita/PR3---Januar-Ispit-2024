using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitBrojIndeksa
{
    public class DrzaveBrojIndeksa
    {
        public List<GradoviBrojIndeksa>Gradovi { get; set; }
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
        public override string ToString()
        {
            return Naziv;
        }

        [NotMapped]
        public string BrojGradova { get 
            {
                if (Gradovi == null || !Gradovi.Any())
                    return "0";
                var brojGradova = Gradovi.Count();
                return brojGradova.ToString();
            } }
    }
}
