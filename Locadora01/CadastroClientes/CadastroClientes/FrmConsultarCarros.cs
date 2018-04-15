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
using MetroFramework;
namespace CadastroClientes
{
    public partial class FrmConsultarCarros : MetroFramework.Forms.MetroForm
    {
        public FrmConsultarCarros()
        {
            InitializeComponent();
        }

        private void FrmConsultarCarros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");
                conn.Open();

                String SQL;

                SQL = "Select * from Carros";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet Dados = new DataSet();

                adapter.Fill(Dados, "Carros");


                DgClientes.DataSource = Dados.Tables["Carros"];
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCarros frm = new FrmCadCarros();
            frm.txtPlaca.Text = DgClientes.SelectedCells[0].Value.ToString();
            frm.txtCategoria.Text = DgClientes.SelectedCells[1].Value.ToString();
            frm.txtCor.Text = DgClientes.SelectedCells[2].Value.ToString();
            frm.TxtModelo.Text = DgClientes.SelectedCells[3].Value.ToString();
            frm.TxtAno.Text = DgClientes.SelectedCells[4].Value.ToString();
            frm.Show();
            frm.button1.Visible = false;
            frm.BtnAlterar.Visible = true;
            
            BtnConsulta_Click(sender, e);
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");

                conn.Open();

                String SQL;
                String cod = DgClientes.SelectedCells[0].Value.ToString();

                SQL = "Delete from carros where Placa= " + cod;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                MetroMessageBox.Show(this, "Os dados foram deletados", "Dados apagados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                cmd.ExecuteNonQuery();

                BtnConsulta_Click(sender, e);
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
    }
}
