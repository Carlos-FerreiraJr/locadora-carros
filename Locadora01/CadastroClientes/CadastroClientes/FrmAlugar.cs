using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework;

namespace CadastroClientes
{
    public partial class FrmAlugar : MetroFramework.Forms.MetroForm
    {
        public FrmAlugar()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(08); _time < time.AddHours(18); _time = _time.AddMinutes(30)) //from 16h to 18h hours
            {
              HoraRetirada.Items.Add(_time.ToShortTimeString());
            }

             time = DateTime.Today;
            for (DateTime _time = time.AddHours(08); _time < time.AddHours(18); _time = _time.AddMinutes(30)) //from 16h to 18h hours
            {
                HoraDev.Items.Add(_time.ToShortTimeString());
            }


        }

        private void FormAlugar_Load(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");


            try
            {
                //CLientes Nome
                String Sql = "Select Codigo, Nome,Endereco from Clientes order by nome";
                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(Sql, conn);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                cboCliente.DataSource = ds.Tables[0];

                cboCliente.DisplayMember = "Nome";

                cboCliente.ValueMember = "Codigo";
                


                //cliente complemento






                //funcionarios
                Sql = "Select Codigo ,Nome From Funcionarios order by nome ";
                
                adapter = new OleDbDataAdapter(Sql, conn);


                ds = new DataSet();

                adapter.Fill(ds);

                cboFuncionario.DataSource = ds.Tables[0];

                cboFuncionario.DisplayMember = "Nome";

                cboFuncionario.ValueMember = "Codigo";

                //Valores,Placa,Categoria
                Sql = "Select c.placa, v.valor from Carros as c, valores as v where c.categoria = v.codigocat";

                adapter = new OleDbDataAdapter(Sql, conn);


                 ds = new DataSet();

                adapter.Fill(ds);

                cboplaca.DataSource = ds.Tables[0];
              
                cboplaca.DisplayMember = "placa";
               
                cboplaca.ValueMember = "valor";
                //Funcionarios
               
               





            }
            catch (Exception)
            {


            }





        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Locadora.mdb");




            try
            {
                conn.Open();

                String SQL;

                SQL = "insert into Aluguel(Cod_cliente,Placa,cod_funcionario,DataRetirada,DataDevolucao,HoraRetirada,HoraDevolucao,Valores) Values('" + cboCliente.Text + "','" + cboplaca.Text + "','" + cboFuncionario.Text + "','" + dataret.Text + "','" + datadev.Text + "','" + HoraRetirada.Text + "','" + HoraDev.Text + "','" +txtvalor.Text+ "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                MetroMessageBox.Show(this, "Cadastro realizado com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmd.ExecuteNonQuery();

                conn.Close();
                cboCliente.SelectedItem = -1;
                cboplaca.SelectedItem = -1;
                cboFuncionario.SelectedItem = -1;
                datadev.Value = DateTime.Now;
               dataret.Value=DateTime.Now;
                HoraRetirada.SelectedItem = -1;
                HoraDev.SelectedItem = -1;

                txtvalor.Clear();
                
             
            


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(cboCliente.SelectedValue.ToString());

            DateTime ret = dataret.Value;
            DateTime dev = datadev.Value;
            TimeSpan dias = dev-ret;

            double valor = (dias.Days + 1) * double.Parse(cboplaca.SelectedValue.ToString());
            MessageBox.Show(valor.ToString());
      

        }

        private void dataret_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void HoraRetirada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            string strTime_Start = HoraRetirada.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Start);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strTime_Start = HoraDev.SelectedItem.ToString();
            string strTime_End = "18:00";
            DateTime dateTime_Start = Convert.ToDateTime(strTime_Start);
            DateTime dateTime_End = Convert.ToDateTime(strTime_End);
        }

        private void txtvalor_Click(object sender, EventArgs e)
        {


                DateTime ret = dataret.Value;
                DateTime dev = datadev.Value;
                TimeSpan dias = dev - ret;
           
                double  valor = (dias.Days + 1) * double.Parse(cboplaca.SelectedValue.ToString());
                txtvalor.Text = valor.ToString();
            
            

            
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void docPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}