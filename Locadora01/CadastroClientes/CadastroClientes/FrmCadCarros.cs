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
    public partial class FrmCadCarros : MetroFramework.Forms.MetroForm
    {
        public FrmCadCarros()
        {
            InitializeComponent();
        }
          public string Codigo;

        private void FrmCadCarros_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");




            try
            {
                conn.Open();

                String SQL;

                SQL = "insert into Carros(Placa,Categoria,Cor,Modelo,Ano) Values('" + txtPlaca.Text + "','" + txtCategoria.Text + "','" + txtCor.Text + "','" + TxtModelo.Text + "','" + TxtAno.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                MetroMessageBox.Show(this, "Cadastro realizado com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmd.ExecuteNonQuery();

                conn.Close();
                txtPlaca.Clear();
                txtCategoria.SelectedIndex = -1;
                txtCor.Clear();
                TxtModelo.Clear();
                TxtAno.Clear();



            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");



            try
            {
                conn.Open();

                String SQL;

                SQL = "update carros set Placa='" + txtPlaca.Text + "',";
                SQL += "Categoria='" + txtCategoria.Text + "',";
                SQL += "Cor='" + txtCor.Text + "',";
                SQL += "Modelo='" + TxtModelo.Text + "',";
                SQL += "Ano='" + TxtAno.Text + "' ";
                SQL += "where Placa=" + Codigo;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                MetroMessageBox.Show(this, "Dados alterados com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmd.ExecuteNonQuery();
               
                conn.Close();
                txtPlaca.Clear();
                txtCategoria.SelectedIndex = -1;
                txtCor.Clear();
                TxtModelo.Clear();
                TxtAno.Clear();




            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }


        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
