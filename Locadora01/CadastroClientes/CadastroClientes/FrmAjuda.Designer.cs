namespace CadastroClientes
{
    partial class FrmAjuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjuda));
            this.MsmPrincipal = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Pcad = new System.Windows.Forms.PictureBox();
            this.Pconsultar = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.Palugar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MsmPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pconsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palugar)).BeginInit();
            this.SuspendLayout();
            // 
            // MsmPrincipal
            // 
            this.MsmPrincipal.Owner = this;
            this.MsmPrincipal.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // Pcad
            // 
            this.Pcad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pcad.Image = ((System.Drawing.Image)(resources.GetObject("Pcad.Image")));
            this.Pcad.Location = new System.Drawing.Point(4, 106);
            this.Pcad.Name = "Pcad";
            this.Pcad.Size = new System.Drawing.Size(539, 293);
            this.Pcad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcad.TabIndex = 86;
            this.Pcad.TabStop = false;
            this.Pcad.Visible = false;
            this.Pcad.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pconsultar
            // 
            this.Pconsultar.Image = ((System.Drawing.Image)(resources.GetObject("Pconsultar.Image")));
            this.Pconsultar.Location = new System.Drawing.Point(4, 106);
            this.Pconsultar.Name = "Pconsultar";
            this.Pconsultar.Size = new System.Drawing.Size(539, 293);
            this.Pconsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pconsultar.TabIndex = 87;
            this.Pconsultar.TabStop = false;
            this.Pconsultar.Visible = false;
            this.Pconsultar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 48;
            this.metroLink1.Location = new System.Drawing.Point(483, 974);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(58, 53);
            this.metroLink1.TabIndex = 90;
            this.metroLink1.UseSelectable = true;
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink2.Location = new System.Drawing.Point(3, 77);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(227, 23);
            this.metroLink2.TabIndex = 91;
            this.metroLink2.Text = "Como Cadastrar?";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink3.Location = new System.Drawing.Point(220, 77);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(194, 23);
            this.metroLink3.TabIndex = 92;
            this.metroLink3.Text = "Como Consultar?";
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroLink4
            // 
            this.metroLink4.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink4.Location = new System.Drawing.Point(403, 77);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(185, 23);
            this.metroLink4.TabIndex = 93;
            this.metroLink4.Text = "Alugar";
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
            // 
            // Palugar
            // 
            this.Palugar.Image = ((System.Drawing.Image)(resources.GetObject("Palugar.Image")));
            this.Palugar.Location = new System.Drawing.Point(23, 106);
            this.Palugar.Name = "Palugar";
            this.Palugar.Size = new System.Drawing.Size(539, 293);
            this.Palugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Palugar.TabIndex = 94;
            this.Palugar.TabStop = false;
            this.Palugar.Visible = false;
            // 
            // FrmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.Palugar);
            this.Controls.Add(this.metroLink4);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.Pconsultar);
            this.Controls.Add(this.Pcad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjuda";
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.FrmAjuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MsmPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pconsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Palugar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager MsmPrincipal;
        private System.Windows.Forms.PictureBox Pcad;
        private System.Windows.Forms.PictureBox Pconsultar;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink4;
        private System.Windows.Forms.PictureBox Palugar;
    }
}