using FIT.Data;
using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmGradoviBrojIndeksa : Form
    {
        private DrzaveBrojIndeksa odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviBrojIndeksa> _grad;
        public event EventHandler formRefresh;
        public frmGradoviBrojIndeksa(DrzaveBrojIndeksa odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
            dgvGrad.AutoGenerateColumns = false;
        }
        private void frmGradoviBrojIndeksa_Load(object sender, EventArgs e)
        {
            pbSlika.Image = Ekstenzije.ToImage(odabranaDrzava.Slika);
            lblNaziv.Text = odabranaDrzava.Naziv;
            Ucitaj();
        }
        private void Ucitaj()
        {
            _grad = db.GradoviBrojIndeksa.Where(g => g.Drzava.Id == odabranaDrzava.Id).ToList();
            if (_grad != null)
            {
                dgvGrad.DataSource = null;
                dgvGrad.DataSource = _grad;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                var noviGrad = new GradoviBrojIndeksa
                {
                    Naziv = txtNaziv.Text,
                    Status = true,
                    DrzavaId = odabranaDrzava.Id
                };
                db.GradoviBrojIndeksa.Add(noviGrad);
                db.SaveChanges();
                Ucitaj();
            }

        }
        private bool Validacija()
        {
            bool Validno = true;
            Validno = Helpers.Validator.ProvjeriUnos(txtNaziv, errorProvider1, Kljucevi.ReqiredValue);
            string uneseniNaziv = txtNaziv.Text.Trim().ToLower();
            if (_grad.Any(g => g.Naziv.ToLower() == uneseniNaziv))
            {
                MessageBox.Show("Grad sa istim nazivom već postoji u ovoj državi.");
                Validno = false;
            }
            return Validno;
        }
        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (txtBroj.Text != "")
            {
                var broj = int.Parse(txtBroj.Text);
                Thread t1 = new Thread(() => Generisi(broj));
                t1.Start();
            }
        }
        private void Generisi(int broj)
        {
            for (int i = 0; i < broj; i++)
            {
                var noviGrad = new GradoviBrojIndeksa
                {
                    Status = cbStatus.Checked,
                    DrzavaId = odabranaDrzava.Id,
                    Naziv = $"Grad {i+1}."
                };
                Thread.Sleep(300);
                string text = $"{DateTime.Now.ToString("dd.MM HH:mm:ss")} -> dodat grad {noviGrad.ToString()} za drzavu {odabranaDrzava.ToString()}"+Environment.NewLine;
                Action updateInfo = () => txtInfo.AppendText(text);
                txtInfo.Invoke(updateInfo);
                db.GradoviBrojIndeksa.Add(noviGrad);
                db.SaveChanges();           
            }
            Action msg = () => { Ucitaj(); MessageBox.Show("Dodavanje uspjesno zavrseno!"); };
            BeginInvoke(msg);
        }
        private void dgvGrad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    var odabraniGrad = _grad[e.RowIndex];
                    if (odabraniGrad.Status == true)
                        odabraniGrad.Status = false;
                    else if (odabraniGrad.Status == false)
                        odabraniGrad.Status = true;
                    db.SaveChanges();
                    Ucitaj();
                }
            }
        }
        private void frmGradoviBrojIndeksa_FormClosed(object sender, FormClosedEventArgs e)
        {
            formRefresh?.Invoke(this, EventArgs.Empty);
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Samo se brojevi mogu unijeti, i broj ne smije biti manji od 1");
            }
            else if (char.IsDigit(e.KeyChar))
            {
                int uneseniBroj = int.Parse(txtBroj.Text + e.KeyChar);
                if (uneseniBroj < 1)
                {
                    e.Handled = true;
                    MessageBox.Show("Broj ne smije biti manji od 1");
                }
            }
        }
    }
}
