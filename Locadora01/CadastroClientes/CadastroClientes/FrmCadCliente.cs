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
    public partial class FrmCadCliente : MetroFramework.Forms.MetroForm
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }
        public string Codigo;
        private void cadClientes_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");



            try
            {
                conn.Open();

                String SQL;

                SQL = "insert into Clientes(Nome,CPF,RG,DataNasc,Telefone,Celular,Email,Endereco,Bairro,Complemento,CNH) Values('" + TxtNome.Text + "','" + TxtCpf.Text + "','" + TxtRG.Text + "','" + TxtNasc.Text + "','" + TxtTel.Text + "','" + TxtCel.Text + "','" + TxtEmail.Text + "','" + TxtEndereco.Text + "','" + TxtBairro.Text + "','" + TxtComplem.Text + "','" + TxtCnh.Text + "')";

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
                TxtCnh.Clear();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnmodifica_Click(object sender, EventArgs e)
        {
            
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");

           

            try
            {
                conn.Open();

                String SQL;

                SQL = "update clientes set nome='" + TxtNome.Text + "',";

                SQL += "CPF='" + TxtCpf.Text + "',";
                SQL += "Rg='" + TxtRG.Text + "',";
                SQL += "DataNasc='" + TxtNasc.Text + "',";
                SQL += "Telefone='" + TxtTel.Text + "',";
                SQL += "Celular='" + TxtCel.Text + "',";
                SQL += "Email='" + TxtEmail.Text + "',";
                SQL += "Endereco='" + TxtEndereco.Text + "',";
                SQL += "Bairro='" + TxtBairro.Text + "',";
                SQL += "Complemento='" + TxtComplem.Text + "' ";
                SQL += "where Codigo=" + Codigo;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                MetroMessageBox.Show(this, "Dados alterados com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                TxtCnh.Clear();

            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }
    } }
}
