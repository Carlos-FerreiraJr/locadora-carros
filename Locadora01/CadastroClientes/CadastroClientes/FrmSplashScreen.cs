using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class FrmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void MetroSplashScreen_Load(object sender, EventArgs e)
        {
            this.StyleManager = MsmSplash;
        }
    }
}
