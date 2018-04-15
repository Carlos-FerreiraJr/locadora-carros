using MetroFramework;
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
    public partial class FrmConsultarClientes : MetroFramework.Forms.MetroForm
    {
        public FrmConsultarClientes()
        {
            InitializeComponent();
        }

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");
                conn.Open();

                String SQL;

                SQL = "Select * from clientes order by nome ";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet Dados = new DataSet();

                adapter.Fill(Dados, "Clientes");


                DgClientes.DataSource = Dados.Tables["Clientes"];
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.Codigo = DgClientes.SelectedCells[0].Value.ToString();
            frm.TxtNome.Text = DgClientes.SelectedCells[1].Value.ToString();
            frm.TxtCpf.Text = DgClientes.SelectedCells[2].Value.ToString();
            frm.TxtRG.Text = DgClientes.SelectedCells[3].Value.ToString();
            frm.TxtNasc.Text = DgClientes.SelectedCells[4].Value.ToString();
            frm.TxtTel.Text = DgClientes.SelectedCells[5].Value.ToString();
            frm.TxtCel.Text = DgClientes.SelectedCells[6].Value.ToString();
            frm.TxtEmail.Text = DgClientes.SelectedCells[7].Value.ToString();
            frm.TxtEndereco.Text = DgClientes.SelectedCells[8].Value.ToString();
            frm.TxtComplem.Text = DgClientes.SelectedCells[9].Value.ToString();
            frm.TxtBairro.Text = DgClientes.SelectedCells[10].Value.ToString();
            frm.button1.Visible = false;
            frm.Btnmodifica.Visible = true;
            frm.Show();
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

                SQL = "Delete from clientes where codigo= " + cod;

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
