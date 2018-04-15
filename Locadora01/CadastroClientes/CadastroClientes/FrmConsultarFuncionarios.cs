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
    public partial class FrmConsultarFuncionarios : MetroFramework.Forms.MetroForm
    {
        public FrmConsultarFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmConsultarFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");
                conn.Open();

                String SQL;

                SQL = "Select * from Funcionarios order by nome ";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet Dados = new DataSet();

                adapter.Fill(Dados, "Funcionarios");


                DgFuncionarios.DataSource = Dados.Tables["Funcionarios"];
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFuncionarios funci = new FrmCadFuncionarios();
            
            funci.TxtNome.Text = DgFuncionarios.SelectedCells[0].Value.ToString();
            funci.TxtCpf.Text = DgFuncionarios.SelectedCells[1].Value.ToString();
            funci.TxtRG.Text = DgFuncionarios.SelectedCells[2].Value.ToString();
            funci.TxtNasc.Text = DgFuncionarios.SelectedCells[3].Value.ToString();
            funci.TxtTel.Text = DgFuncionarios.SelectedCells[4].Value.ToString();
            funci.TxtCel.Text = DgFuncionarios.SelectedCells[5].Value.ToString();
            funci.TxtEmail.Text = DgFuncionarios.SelectedCells[6].Value.ToString();
            funci.TxtEndereco.Text = DgFuncionarios.SelectedCells[7].Value.ToString();
            funci.TxtComplem.Text = DgFuncionarios.SelectedCells[8].Value.ToString();
            funci.TxtBairro.Text = DgFuncionarios.SelectedCells[9].Value.ToString();
            funci.button1.Visible = false;
            
            funci.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Carlos\Desktop\Locadora.mdb");
                conn.Open();

                String SQL;
                String cod = DgFuncionarios.SelectedCells[0].Value.ToString();

                SQL = "Delete from Funcionarios where codigo= " + cod;

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

