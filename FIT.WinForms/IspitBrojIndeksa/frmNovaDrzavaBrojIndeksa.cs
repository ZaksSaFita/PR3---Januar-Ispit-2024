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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmNovaDrzavaBrojIndeksa : Form
    {
        private DrzaveBrojIndeksa odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaDrzavaBrojIndeksa(DrzaveBrojIndeksa odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }
        public frmNovaDrzavaBrojIndeksa()
        {
            InitializeComponent();
        }
        private void frmNovaDrzavaBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            if (odabranaDrzava != null)
            {
                pbSlika.Image = Helpers.Ekstenzije.ToImage(odabranaDrzava.Slika);
                txtNaziv.Text = odabranaDrzava.Naziv;
                cbStatus.Checked = odabranaDrzava.Status;
            }
        }
        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (odabranaDrzava !=null)
                EditujDrzavu();
            else if (Validacija() && odabranaDrzava == null)
                DodajDrzavu();
        }
        private void EditujDrzavu()
        {
            odabranaDrzava.Status = cbStatus.Checked; 
            odabranaDrzava.Slika = Helpers.Ekstenzije.ToByteArray(pbSlika.Image);
            odabranaDrzava.Naziv = txtNaziv.Text;
            db.DrzaveBrojIndeksa.Update(odabranaDrzava);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
        private void DodajDrzavu()
        {
            var novaDrzava = new DrzaveBrojIndeksa
            {
                Slika = Helpers.Ekstenzije.ToByteArray(pbSlika.Image),
                Naziv = txtNaziv.Text,
                Status = cbStatus.Checked
            };
            db.DrzaveBrojIndeksa.Add(novaDrzava);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
        private bool Validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue) &&
                   Helpers.Validator.ProvjeriUnos(txtNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
