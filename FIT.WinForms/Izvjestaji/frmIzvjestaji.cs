using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveBrojIndeksa odabranaDrzava;
        public frmIzvjestaji(DrzaveBrojIndeksa odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("grad",odabranaDrzava.Gradovi.Count().ToString()));
            reportViewer1.LocalReport.SetParameters(parametri);

            var tabela = new dsDLWMS.dsDLWMSDataTable();
            for (int i = 0; i < odabranaDrzava.Gradovi.Count; i++)
            {
                var RED = tabela.NewdsDLWMSRow();
                RED.Rb = $"{i + 1}.";
                RED.Grad = odabranaDrzava.Gradovi[i].ToString();
                RED.Drzava = odabranaDrzava.ToString();             
                if (odabranaDrzava.Gradovi[i].Status == true)
                    RED.Aktivan = "DA";
                else if (odabranaDrzava.Gradovi[i].Status == false)
                    RED.Aktivan = "NE";
                tabela.Rows.Add(RED);
            }

            var source = new ReportDataSource();
            source.Name = "dsDLWMS";
            source.Value= tabela;

            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            reportViewer1.RefreshReport();
        }
    }
}
