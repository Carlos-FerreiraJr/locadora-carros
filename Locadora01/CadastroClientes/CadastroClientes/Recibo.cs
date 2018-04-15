using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CadastroClientes
{
    public partial class Recibo : Form
    {
        public Recibo(string nome ,string valor, string valor_extenso, string data,string servico,string empresa)
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource = "CadastroClientes.Recibo.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p =
           new Microsoft.Reporting.WinForms.ReportParameter[6];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("nome", nome);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("valor", valor);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("valor_extenso", valor_extenso);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("data", data);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("servico", servico);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("empresa", empresa);
            reportViewer1.LocalReport.SetParameters(p);


        }

        private void form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void Recibo_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
