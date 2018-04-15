using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            for (int i = 0; i <= 1000; i++)
               Thread.Sleep(1);
            t.Abort();
            this.StyleManager = MsmPrincipal;
            
        }
        
       public void Loading()
        {
            FrmSplashScreen frm = new FrmSplashScreen();
            Application.Run(frm);
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmCadCarros car = new FrmCadCarros();

            car.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmConsultarClientes frm = new FrmConsultarClientes();

            frm.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmConsultarCarros carro = new FrmConsultarCarros();

            carro.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmConsultarFuncionarios func = new FrmConsultarFuncionarios();
            
            func.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmConsultarValor val = new FrmConsultarValor();

            val.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
                
            }
            
            FrmCadCliente frm = new FrmCadCliente();
            frm.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
           FrmCadFuncionarios func = new FrmCadFuncionarios();

            func.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmCadValores value = new FrmCadValores();

            value.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
          FrmAlugar alug = new FrmAlugar();

            alug.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            ctmenu.Show(metroLink1,0,metroLink1.Height);
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctmenu_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void alterarCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjuda ajuda = new FrmAjuda();
            ajuda.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            FrmConsultarAluguel alug = new FrmConsultarAluguel();
            alug.Show();
        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void metroToolTip1_Popup_1(object sender, PopupEventArgs e)
        {
            
        }
    }
}
