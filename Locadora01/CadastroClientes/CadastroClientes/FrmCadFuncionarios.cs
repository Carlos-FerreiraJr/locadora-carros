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
    public partial class FrmCadFuncionarios : MetroFramework.Forms.MetroForm
    {
        public FrmCadFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmCadFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");



            try
            {
                conn.Open();

                String SQL;

                SQL = "insert into Funcionarios(Nome,CPF,Rg,DataNasc,Telefone,Celular,Email,Endereco,Bairro,Complemento,DataContrato,SalarioHora) Values('" + TxtNome.Text + "','" + TxtCpf.Text + "','" +TxtRG.Text  + "','" +TxtNasc.Text  + "','" + TxtTel.Text+ "','" +TxtCel.Text + "','" + TxtEmail.Text + "','" + TxtEndereco.Text + "','" + TxtBairro.Text + "','" + TxtComplem.Text + "',+'" + TxtContrato2.Text + "','"+TxtSala+"')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                MetroMessageBox.Show(this, "Cadastro realizado com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                cmd.ExecuteNonQuery();

                conn.Close();
                TxtNome.Clear();
                TxtCpf.Clear();
                TxtRG.Clear();
                TxtNasc.Clear();
                TxtTel.Clear();
                TxtCel.Clear();
                TxtEmail.Clear();
                TxtEndereco.Clear();
                TxtBairro.Clear();
                TxtComplem.Clear();
                TxtSala.Clear();




            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TxtEmail_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnmodifica_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
