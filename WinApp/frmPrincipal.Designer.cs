namespace WinApp
{
    partial class frmPrincipal
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
            this.mnuSuperior = new System.Windows.Forms.MenuStrip();
            this.mnuSup_Fich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Fich_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_Cump = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_Fahr = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_CalcNota = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_NomeEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_QueHorSao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_QuantoTempo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_Cambio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_Cambio_Radio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_Cambio_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Jane = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Jane_Casc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Jane_Hor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Jane_Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSup_Exer_Cambio_DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSuperior
            // 
            this.mnuSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSup_Fich,
            this.mnuSup_Exem,
            this.mnuSup_Exer,
            this.mnuSup_Jane});
            this.mnuSuperior.Location = new System.Drawing.Point(0, 0);
            this.mnuSuperior.Name = "mnuSuperior";
            this.mnuSuperior.Size = new System.Drawing.Size(1022, 24);
            this.mnuSuperior.TabIndex = 1;
            this.mnuSuperior.Text = "menuStrip1";
            // 
            // mnuSup_Fich
            // 
            this.mnuSup_Fich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSup_Fich_Sair});
            this.mnuSup_Fich.Name = "mnuSup_Fich";
            this.mnuSup_Fich.Size = new System.Drawing.Size(61, 20);
            this.mnuSup_Fich.Text = "Ficheiro";
            // 
            // mnuSup_Fich_Sair
            // 
            this.mnuSup_Fich_Sair.Name = "mnuSup_Fich_Sair";
            this.mnuSup_Fich_Sair.Size = new System.Drawing.Size(93, 22);
            this.mnuSup_Fich_Sair.Text = "Sair";
            this.mnuSup_Fich_Sair.Click += new System.EventHandler(this.mnuSup_Fich_Sair_Click);
            // 
            // mnuSup_Exem
            // 
            this.mnuSup_Exem.Name = "mnuSup_Exem";
            this.mnuSup_Exem.Size = new System.Drawing.Size(70, 20);
            this.mnuSup_Exem.Text = "Exemplos";
            // 
            // mnuSup_Exer
            // 
            this.mnuSup_Exer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSup_Exer_Cump,
            this.mnuSup_Exer_Fahr,
            this.mnuSup_Exer_CalcNota,
            this.mnuSup_Exer_NomeEmail,
            this.mnuSup_Exer_QueHorSao,
            this.mnuSup_Exer_QuantoTempo,
            this.mnuSup_Exer_Cambio});
            this.mnuSup_Exer.Name = "mnuSup_Exer";
            this.mnuSup_Exer.Size = new System.Drawing.Size(71, 20);
            this.mnuSup_Exer.Text = "Exercícios";
            // 
            // mnuSup_Exer_Cump
            // 
            this.mnuSup_Exer_Cump.Name = "mnuSup_Exer_Cump";
            this.mnuSup_Exer_Cump.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_Cump.Text = "Cumprimentos";
            this.mnuSup_Exer_Cump.Click += new System.EventHandler(this.mnuSup_Exer_Cump_Click);
            // 
            // mnuSup_Exer_Fahr
            // 
            this.mnuSup_Exer_Fahr.Name = "mnuSup_Exer_Fahr";
            this.mnuSup_Exer_Fahr.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_Fahr.Text = "Fahrenheit";
            this.mnuSup_Exer_Fahr.Click += new System.EventHandler(this.mnuSup_Exer_Fahr_Click);
            // 
            // mnuSup_Exer_CalcNota
            // 
            this.mnuSup_Exer_CalcNota.Name = "mnuSup_Exer_CalcNota";
            this.mnuSup_Exer_CalcNota.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_CalcNota.Text = "Calcular Nota";
            this.mnuSup_Exer_CalcNota.Click += new System.EventHandler(this.mnuSup_Exer_CalcNota_Click);
            // 
            // mnuSup_Exer_NomeEmail
            // 
            this.mnuSup_Exer_NomeEmail.Name = "mnuSup_Exer_NomeEmail";
            this.mnuSup_Exer_NomeEmail.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_NomeEmail.Text = "Nome e Email";
            this.mnuSup_Exer_NomeEmail.Click += new System.EventHandler(this.mnuSup_Exer_NomeEmail_Click);
            // 
            // mnuSup_Exer_QueHorSao
            // 
            this.mnuSup_Exer_QueHorSao.Name = "mnuSup_Exer_QueHorSao";
            this.mnuSup_Exer_QueHorSao.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_QueHorSao.Text = "Que Horas São";
            this.mnuSup_Exer_QueHorSao.Click += new System.EventHandler(this.mnuSup_Exer_QueHorSao_Click);
            // 
            // mnuSup_Exer_QuantoTempo
            // 
            this.mnuSup_Exer_QuantoTempo.Name = "mnuSup_Exer_QuantoTempo";
            this.mnuSup_Exer_QuantoTempo.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_QuantoTempo.Text = "Quanto Tempo Passou";
            this.mnuSup_Exer_QuantoTempo.Click += new System.EventHandler(this.mnuSup_Exer_QuantoTempo_Click);
            // 
            // mnuSup_Exer_Cambio
            // 
            this.mnuSup_Exer_Cambio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSup_Exer_Cambio_Radio,
            this.mnuSup_Exer_Cambio_Check,
            this.mnuSup_Exer_Cambio_DropDown});
            this.mnuSup_Exer_Cambio.Name = "mnuSup_Exer_Cambio";
            this.mnuSup_Exer_Cambio.Size = new System.Drawing.Size(193, 22);
            this.mnuSup_Exer_Cambio.Text = "Cambio";
            // 
            // mnuSup_Exer_Cambio_Radio
            // 
            this.mnuSup_Exer_Cambio_Radio.Name = "mnuSup_Exer_Cambio_Radio";
            this.mnuSup_Exer_Cambio_Radio.Size = new System.Drawing.Size(180, 22);
            this.mnuSup_Exer_Cambio_Radio.Text = "Radio Button";
            this.mnuSup_Exer_Cambio_Radio.Click += new System.EventHandler(this.mnuSup_Exer_Cambio_Radio_Click);
            // 
            // mnuSup_Exer_Cambio_Check
            // 
            this.mnuSup_Exer_Cambio_Check.Name = "mnuSup_Exer_Cambio_Check";
            this.mnuSup_Exer_Cambio_Check.Size = new System.Drawing.Size(180, 22);
            this.mnuSup_Exer_Cambio_Check.Text = "Check Box";
            this.mnuSup_Exer_Cambio_Check.Click += new System.EventHandler(this.mnuSup_Exer_Cambio_Check_Click);
            // 
            // mnuSup_Jane
            // 
            this.mnuSup_Jane.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSup_Jane_Casc,
            this.mnuSup_Jane_Hor,
            this.mnuSup_Jane_Ver});
            this.mnuSup_Jane.Name = "mnuSup_Jane";
            this.mnuSup_Jane.Size = new System.Drawing.Size(51, 20);
            this.mnuSup_Jane.Text = "Janela";
            // 
            // mnuSup_Jane_Casc
            // 
            this.mnuSup_Jane_Casc.Name = "mnuSup_Jane_Casc";
            this.mnuSup_Jane_Casc.Size = new System.Drawing.Size(129, 22);
            this.mnuSup_Jane_Casc.Text = "Cascata";
            this.mnuSup_Jane_Casc.Click += new System.EventHandler(this.mnuSup_Jane_Casc_Click);
            // 
            // mnuSup_Jane_Hor
            // 
            this.mnuSup_Jane_Hor.Name = "mnuSup_Jane_Hor";
            this.mnuSup_Jane_Hor.Size = new System.Drawing.Size(129, 22);
            this.mnuSup_Jane_Hor.Text = "Horizontal";
            this.mnuSup_Jane_Hor.Click += new System.EventHandler(this.mnuSup_Jane_Hor_Click);
            // 
            // mnuSup_Jane_Ver
            // 
            this.mnuSup_Jane_Ver.Name = "mnuSup_Jane_Ver";
            this.mnuSup_Jane_Ver.Size = new System.Drawing.Size(129, 22);
            this.mnuSup_Jane_Ver.Text = "Vertical";
            this.mnuSup_Jane_Ver.Click += new System.EventHandler(this.mnuSup_Jane_Ver_Click);
            // 
            // mnuSup_Exer_Cambio_DropDown
            // 
            this.mnuSup_Exer_Cambio_DropDown.Name = "mnuSup_Exer_Cambio_DropDown";
            this.mnuSup_Exer_Cambio_DropDown.Size = new System.Drawing.Size(180, 22);
            this.mnuSup_Exer_Cambio_DropDown.Text = "Drop Down";
            this.mnuSup_Exer_Cambio_DropDown.Click += new System.EventHandler(this.mnuSup_Exer_Cambio_DropDown_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 565);
            this.Controls.Add(this.mnuSuperior);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuSuperior;
            this.Name = "frmPrincipal";
            this.Text = "Formulário Principal";
            this.mnuSuperior.ResumeLayout(false);
            this.mnuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSuperior;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Fich;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Fich_Sair;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exem;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_Cump;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_Fahr;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_CalcNota;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Jane;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Jane_Casc;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Jane_Hor;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Jane_Ver;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_NomeEmail;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_QueHorSao;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_QuantoTempo;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_Cambio;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_Cambio_Radio;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_Cambio_Check;
        private System.Windows.Forms.ToolStripMenuItem mnuSup_Exer_Cambio_DropDown;
    }
}