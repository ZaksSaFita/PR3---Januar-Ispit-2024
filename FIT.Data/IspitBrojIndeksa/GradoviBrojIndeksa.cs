using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitBrojIndeksa
{
    public class GradoviBrojIndeksa
    {
        public int Id { get; set; }
        public int DrzavaId { get; set; }
        public DrzaveBrojIndeksa Drzava { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
