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
    public partial class FrmCadValores : MetroFramework.Forms.MetroForm
    {
        public FrmCadValores()
        {
            InitializeComponent();
        }

        private void FrmCadValores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");



            try
            {
                conn.Open();

                String SQL;

                SQL = "Update Valores set valor ='" + TxtValores.Text + "' where CodigoCat = '" +CboCate.Text+"'";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                MetroMessageBox.Show(this, "Cadastro realizado com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                cmd.ExecuteNonQuery();

                conn.Close();
                TxtValores.Clear();
                CboCate.SelectedIndex = -1;


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