namespace CadastroClientes
{
    partial class FrmAlugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlugar));
            this.cboCliente = new MetroFramework.Controls.MetroComboBox();
            this.cboplaca = new MetroFramework.Controls.MetroComboBox();
            this.cboFuncionario = new MetroFramework.Controls.MetroComboBox();
            this.dataret = new MetroFramework.Controls.MetroDateTime();
            this.datadev = new MetroFramework.Controls.MetroDateTime();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.HoraDevolucao = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.HoraRetirada = new MetroFramework.Controls.MetroComboBox();
            this.HoraDev = new MetroFramework.Controls.MetroComboBox();
            this.txtvalor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.docPrint = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.ItemHeight = 23;
            this.cboCliente.Location = new System.Drawing.Point(28, 53);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(187, 29);
            this.cboCliente.TabIndex = 81;
            this.cboCliente.UseSelectable = true;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // cboplaca
            // 
            this.cboplaca.FormattingEnabled = true;
            this.cboplaca.ItemHeight = 23;
            this.cboplaca.Location = new System.Drawing.Point(28, 38);
            this.cboplaca.Name = "cboplaca";
            this.cboplaca.Size = new System.Drawing.Size(182, 29);
            this.cboplaca.TabIndex = 83;
            this.cboplaca.UseSelectable = true;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.ItemHeight = 23;
            this.cboFuncionario.Location = new System.Drawing.Point(28, 121);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(187, 29);
            this.cboFuncionario.TabIndex = 84;
            this.cboFuncionario.UseSelectable = true;
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // dataret
            // 
            this.dataret.Location = new System.Drawing.Point(22, 45);
            this.dataret.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataret.Name = "dataret";
            this.dataret.Size = new System.Drawing.Size(182, 29);
            this.dataret.TabIndex = 85;
            this.dataret.ValueChanged += new System.EventHandler(this.dataret_ValueChanged);
            // 
            // datadev
            // 
            this.datadev.Location = new System.Drawing.Point(22, 99);
            this.datadev.MinimumSize = new System.Drawing.Size(0, 29);
            this.datadev.Name = "datadev";
            this.datadev.Size = new System.Drawing.Size(182, 29);
            this.datadev.TabIndex = 86;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Green;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(523, 8);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(73, 36);
            this.metroLink1.TabIndex = 95;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 96;
            this.metroLabel1.Text = "Cliente";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "Placa";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 98;
            this.metroLabel3.Text = "Funcionário ";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.TabIndex = 99;
            this.metroLabel4.Text = "Data de Retirada";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 19);
            this.metroLabel5.TabIndex = 100;
            this.metroLabel5.Text = "Data de Devolução";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 146);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(110, 19);
            this.metroLabel6.TabIndex = 101;
            this.metroLabel6.Text = "Hora de Retirada";
            // 
            // HoraDevolucao
            // 
            this.HoraDevolucao.AutoSize = true;
            this.HoraDevolucao.Location = new System.Drawing.Point(22, 204);
            this.HoraDevolucao.Name = "HoraDevolucao";
            this.HoraDevolucao.Size = new System.Drawing.Size(126, 19);
            this.HoraDevolucao.TabIndex = 102;
            this.HoraDevolucao.Text = "Hora de Devolução ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(424, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 103;
            this.button1.Text = "Alugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoraRetirada
            // 
            this.HoraRetirada.FormattingEnabled = true;
            this.HoraRetirada.ItemHeight = 23;
            this.HoraRetirada.Location = new System.Drawing.Point(22, 168);
            this.HoraRetirada.Name = "HoraRetirada";
            this.HoraRetirada.Size = new System.Drawing.Size(182, 29);
            this.HoraRetirada.TabIndex = 105;
            this.HoraRetirada.UseSelectable = true;
            this.HoraRetirada.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // HoraDev
            // 
            this.HoraDev.FormattingEnabled = true;
            this.HoraDev.ItemHeight = 23;
            this.HoraDev.Location = new System.Drawing.Point(22, 226);
            this.HoraDev.Name = "HoraDev";
            this.HoraDev.Size = new System.Drawing.Size(182, 29);
            this.HoraDev.TabIndex = 106;
            this.HoraDev.UseSelectable = true;
            this.HoraDev.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // txtvalor
            // 
            // 
            // 
            // 
            this.txtvalor.CustomButton.Image = null;
            this.txtvalor.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtvalor.CustomButton.Name = "";
            this.txtvalor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtvalor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtvalor.CustomButton.TabIndex = 1;
            this.txtvalor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtvalor.CustomButton.UseSelectable = true;
            this.txtvalor.CustomButton.Visible = false;
            this.txtvalor.Lines = new string[0];
            this.txtvalor.Location = new System.Drawing.Point(75, 81);
            this.txtvalor.MaxLength = 32767;
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.PasswordChar = '\0';
            this.txtvalor.ReadOnly = true;
            this.txtvalor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtvalor.SelectedText = "";
            this.txtvalor.SelectionLength = 0;
            this.txtvalor.SelectionStart = 0;
            this.txtvalor.ShortcutsEnabled = true;
            this.txtvalor.Size = new System.Drawing.Size(104, 23);
            this.txtvalor.TabIndex = 107;
            this.txtvalor.UseSelectable = true;
            this.txtvalor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtvalor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtvalor.Click += new System.EventHandler(this.txtvalor_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(124, -3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 108;
            this.metroLabel7.Text = "Preço";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(163, 260);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(0, 0);
            this.metroLabel9.TabIndex = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cboFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(30, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 156);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.dataret);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.datadev);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.HoraRetirada);
            this.groupBox3.Controls.Add(this.HoraDev);
            this.groupBox3.Controls.Add(this.HoraDevolucao);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Location = new System.Drawing.Point(21, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 293);
            this.groupBox3.TabIndex = 112;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(107, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.TabIndex = 114;
            this.metroLabel10.Text = "Datas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel13);
            this.groupBox4.Controls.Add(this.metroComboBox2);
            this.groupBox4.Controls.Add(this.metroComboBox1);
            this.groupBox4.Controls.Add(this.metroLabel12);
            this.groupBox4.Controls.Add(this.metroLabel11);
            this.groupBox4.Controls.Add(this.cboplaca);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Location = new System.Drawing.Point(288, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 224);
            this.groupBox4.TabIndex = 113;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(29, 146);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(52, 19);
            this.metroLabel13.TabIndex = 120;
            this.metroLabel13.Text = "Estado ";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Vazio",
            "1/4 Vazio",
            "1/2 Cheio",
            "Cheio"});
            this.metroComboBox2.Location = new System.Drawing.Point(28, 172);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(182, 29);
            this.metroComboBox2.TabIndex = 119;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Vazio",
            "1/4 Vazio",
            "1/2 Cheio",
            "Cheio"});
            this.metroComboBox1.Location = new System.Drawing.Point(29, 99);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(182, 29);
            this.metroComboBox1.TabIndex = 118;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(28, 77);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(106, 19);
            this.metroLabel12.TabIndex = 115;
            this.metroLabel12.Text = "Nível do tanque ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(98, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(43, 19);
            this.metroLabel11.TabIndex = 114;
            this.metroLabel11.Text = "Carro";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(106, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 19);
            this.metroLabel8.TabIndex = 98;
            this.metroLabel8.Text = "Dados";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroLabel16);
            this.groupBox5.Controls.Add(this.metroLabel7);
            this.groupBox5.Controls.Add(this.txtvalor);
            this.groupBox5.Location = new System.Drawing.Point(288, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 190);
            this.groupBox5.TabIndex = 114;
            this.groupBox5.TabStop = false;
            // 
            // docPrint
            // 
            this.docPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.docPrint_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.docPrint;
            this.printDialog1.UseEXDialog = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(75, 59);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(83, 19);
            this.metroLabel16.TabIndex = 115;
            this.metroLabel16.Text = "Exibir preço ";
            // 
            // FrmAlugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 552);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLink1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlugar";
            this.Text = "Alugar";
            this.Load += new System.EventHandler(this.FormAlugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboCliente;
        private MetroFramework.Controls.MetroComboBox cboplaca;
        private MetroFramework.Controls.MetroComboBox cboFuncionario;
        private MetroFramework.Controls.MetroDateTime dataret;
        private MetroFramework.Controls.MetroDateTime datadev;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel HoraDevolucao;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox HoraDev;
        private MetroFramework.Controls.MetroComboBox HoraRetirada;
        private MetroFramework.Controls.MetroTextBox txtvalor;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Drawing.Printing.PrintDocument docPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel16;
    }
}