﻿using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
using FIT.WinForms.IspitBrojIndeksa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms
{
    public partial class frmPocetna : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDG_Click(object sender, EventArgs e)
        {
            frmDrzaveBrojIndeksa frmDrzava = new frmDrzaveBrojIndeksa();
            frmDrzava.ShowDialog();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            frmPretragaBrojIndeksa frmPretraga = new frmPretragaBrojIndeksa();
            frmPretraga.ShowDialog();
        }
    }
}
