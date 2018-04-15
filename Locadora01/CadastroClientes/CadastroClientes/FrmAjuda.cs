using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
namespace CadastroClientes
{
    public partial class FrmAjuda : MetroFramework.Forms.MetroForm
    {
        public FrmAjuda()
        {
            InitializeComponent();
            this.StyleManager = MsmPrincipal;
        }

        private void FrmAjuda_Load(object sender, EventArgs e)
        {
            
        }

       
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Palugar.Visible = false;
            Pconsultar.Visible = false;
            Pcad.Visible = true;
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            Palugar.Visible = false;
            Pcad.Visible = false;
            Pconsultar.Visible = true;
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            Pcad.Visible = false;
            Pconsultar.Visible = false;
            Palugar.Visible = true;
        }
    }
}
