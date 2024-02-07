using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmDrzaveBrojIndeksa : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveBrojIndeksa> _drzave;
        public frmDrzaveBrojIndeksa()
        {
            InitializeComponent();
            dgvDrzava.AutoGenerateColumns = false;
        }
        private void frmDrzaveBrojIndeksa_Load(object sender, EventArgs e)
        {
            Ucitaj();
            timer1.Start();
        }
        private void Ucitaj()
        {
            _drzave = db.DrzaveBrojIndeksa.Include(d => d.Gradovi).ToList();
            if (_drzave != null)
            {
                dgvDrzava.DataSource = null;
                dgvDrzava.DataSource = _drzave;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
        }
        private void btnDrzava_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaBrojIndeksa frmNova = new frmNovaDrzavaBrojIndeksa();
            if (frmNova.ShowDialog() == DialogResult.OK)
                Ucitaj();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var odabran = dgvDrzava.SelectedRows;
            if (odabran.Count > 0)
            {
                DrzaveBrojIndeksa? odabranaDrzava = odabran[0].DataBoundItem as DrzaveBrojIndeksa;
                if (odabranaDrzava != null)
                {
                    frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(odabranaDrzava);
                    frmIzvjestaji.ShowDialog();
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex != 4)
                {
                    var odabranaDrzava = _drzave[e.RowIndex];
                    frmNovaDrzavaBrojIndeksa frmOdabrana = new frmNovaDrzavaBrojIndeksa(odabranaDrzava);
                    if (frmOdabrana.ShowDialog() == DialogResult.OK)
                        Ucitaj();
                }
            }
        }
        private void dgvDrzava_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    var odabranaDrzava = _drzave[e.RowIndex];
                    frmGradoviBrojIndeksa frmGrad = new frmGradoviBrojIndeksa(odabranaDrzava);
                    frmGrad.formRefresh += refreshDGV;
                    frmGrad.ShowDialog();
                }
            }
        }
        private void refreshDGV (object sender, EventArgs e)
        {
            Ucitaj();
        }
    }
}
