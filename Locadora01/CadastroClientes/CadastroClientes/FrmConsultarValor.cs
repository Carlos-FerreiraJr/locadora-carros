using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FrmConsultarValor : MetroFramework.Forms.MetroForm
    {
        public FrmConsultarValor()
        {
            InitializeComponent();
        }

        private void FrmConsultarValor_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");
                conn.Open();

                String SQL;

                SQL = "Select * from valores";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet Dados = new DataSet();

                adapter.Fill(Dados, "valores");


                DgValores.DataSource = Dados.Tables["valores"];
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
