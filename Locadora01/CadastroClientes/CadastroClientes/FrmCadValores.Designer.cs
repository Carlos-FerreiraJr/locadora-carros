namespace CadastroClientes
{
    partial class FrmCadValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadValores));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCate = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtValores = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Valor";
            // 
            // CboCate
            // 
            this.CboCate.FormattingEnabled = true;
            this.CboCate.ItemHeight = 23;
            this.CboCate.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.CboCate.Location = new System.Drawing.Point(23, 88);
            this.CboCate.Name = "CboCate";
            this.CboCate.Size = new System.Drawing.Size(167, 29);
            this.CboCate.TabIndex = 66;
            this.CboCate.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(175, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtValores
            // 
            // 
            // 
            // 
            this.TxtValores.CustomButton.Image = null;
            this.TxtValores.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.TxtValores.CustomButton.Name = "";
            this.TxtValores.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtValores.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtValores.CustomButton.TabIndex = 1;
            this.TxtValores.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtValores.CustomButton.UseSelectable = true;
            this.TxtValores.CustomButton.Visible = false;
            this.TxtValores.Lines = new string[0];
            this.TxtValores.Location = new System.Drawing.Point(26, 149);
            this.TxtValores.MaxLength = 32767;
            this.TxtValores.Name = "TxtValores";
            this.TxtValores.PasswordChar = '\0';
            this.TxtValores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtValores.SelectedText = "";
            this.TxtValores.SelectionLength = 0;
            this.TxtValores.SelectionStart = 0;
            this.TxtValores.ShortcutsEnabled = true;
            this.TxtValores.Size = new System.Drawing.Size(164, 23);
            this.TxtValores.TabIndex = 67;
            this.TxtValores.UseSelectable = true;
            this.TxtValores.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtValores.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(213, 7);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(69, 36);
            this.metroLink1.TabIndex = 84;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // FrmCadValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtValores);
            this.Controls.Add(this.CboCate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadValores";
            this.Text = "Valores";
            this.Load += new System.EventHandler(this.FrmCadValores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox TxtValores;
        public MetroFramework.Controls.MetroComboBox CboCate;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}