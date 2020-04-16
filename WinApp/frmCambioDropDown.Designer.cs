namespace WinApp
{
    partial class frmCambioDropDown
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtValorEuros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMoedaSelecionada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 128);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 24);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label2";
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(12, 78);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(150, 39);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtValorEuros
            // 
            this.txtValorEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEuros.Location = new System.Drawing.Point(12, 43);
            this.txtValorEuros.Name = "txtValorEuros";
            this.txtValorEuros.Size = new System.Drawing.Size(150, 29);
            this.txtValorEuros.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor em €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Moeda";
            // 
            // cbMoedaSelecionada
            // 
            this.cbMoedaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoedaSelecionada.FormattingEnabled = true;
            this.cbMoedaSelecionada.Items.AddRange(new object[] {
            "Dollar",
            "Libra",
            "Iéne",
            "SEK"});
            this.cbMoedaSelecionada.Location = new System.Drawing.Point(190, 43);
            this.cbMoedaSelecionada.Name = "cbMoedaSelecionada";
            this.cbMoedaSelecionada.Size = new System.Drawing.Size(161, 32);
            this.cbMoedaSelecionada.TabIndex = 9;
            // 
            // frmCambioDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 199);
            this.Controls.Add(this.cbMoedaSelecionada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorEuros);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioDropDown";
            this.Text = "frmCambioDropDown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtValorEuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMoedaSelecionada;
    }
}