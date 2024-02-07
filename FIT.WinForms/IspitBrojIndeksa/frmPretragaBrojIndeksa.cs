using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> _studenti;
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }
        private void frmPretragaBrojIndeksa_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.DrzaveBrojIndeksa.ToList();
            cmbGrad.DataSource = db.GradoviBrojIndeksa.ToList();
            UcitajGradove();
            Ucitaj();
        }
        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }
        private void Ucitaj()
        {
            var grad = cmbGrad.SelectedItem as GradoviBrojIndeksa;

            _studenti = db.Studenti.Include(s => s.Grad).Include(s => s.polozeni)
                .Where(s => s.Grad == grad)
                .ToList();

            if (_studenti != null)
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = _studenti;
            }
            if (_studenti?.Count<1)
                MessageBox.Show($"U bazi nije evidentiran niti jedan student rođen u gradu {grad} ({grad.Drzava}).");
        }
        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajGradove();
        }
        private void UcitajGradove()
        {
                var drzava = cmbDrzava.SelectedItem as DrzaveBrojIndeksa;
                cmbGrad.DataSource = drzava?.Gradovi;
        }
    }
}
