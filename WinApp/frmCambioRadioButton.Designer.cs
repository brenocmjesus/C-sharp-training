namespace WinApp
{
    partial class frmCambioRadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorEuros = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSek = new System.Windows.Forms.RadioButton();
            this.rbIene = new System.Windows.Forms.RadioButton();
            this.rbLibra = new System.Windows.Forms.RadioButton();
            this.rbDollar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em €";
            // 
            // txtValorEuros
            // 
            this.txtValorEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEuros.Location = new System.Drawing.Point(12, 43);
            this.txtValorEuros.Name = "txtValorEuros";
            this.txtValorEuros.Size = new System.Drawing.Size(150, 29);
            this.txtValorEuros.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(12, 78);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(150, 39);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 128);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 24);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSek);
            this.groupBox1.Controls.Add(this.rbIene);
            this.groupBox1.Controls.Add(this.rbLibra);
            this.groupBox1.Controls.Add(this.rbDollar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // rbSek
            // 
            this.rbSek.AutoSize = true;
            this.rbSek.Location = new System.Drawing.Point(7, 120);
            this.rbSek.Name = "rbSek";
            this.rbSek.Size = new System.Drawing.Size(65, 28);
            this.rbSek.TabIndex = 3;
            this.rbSek.TabStop = true;
            this.rbSek.Text = "SEK";
            this.rbSek.UseVisualStyleBackColor = true;
            // 
            // rbIene
            // 
            this.rbIene.AutoSize = true;
            this.rbIene.Location = new System.Drawing.Point(7, 85);
            this.rbIene.Name = "rbIene";
            this.rbIene.Size = new System.Drawing.Size(65, 28);
            this.rbIene.TabIndex = 2;
            this.rbIene.TabStop = true;
            this.rbIene.Text = "Iéne";
            this.rbIene.UseVisualStyleBackColor = true;
            // 
            // rbLibra
            // 
            this.rbLibra.AutoSize = true;
            this.rbLibra.Location = new System.Drawing.Point(7, 51);
            this.rbLibra.Name = "rbLibra";
            this.rbLibra.Size = new System.Drawing.Size(69, 28);
            this.rbLibra.TabIndex = 1;
            this.rbLibra.TabStop = true;
            this.rbLibra.Text = "Libra";
            this.rbLibra.UseVisualStyleBackColor = true;
            // 
            // rbDollar
            // 
            this.rbDollar.AutoSize = true;
            this.rbDollar.Location = new System.Drawing.Point(7, 20);
            this.rbDollar.Name = "rbDollar";
            this.rbDollar.Size = new System.Drawing.Size(76, 28);
            this.rbDollar.TabIndex = 0;
            this.rbDollar.TabStop = true;
            this.rbDollar.Text = "Dollar";
            this.rbDollar.UseVisualStyleBackColor = true;
            // 
            // frmCambioRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorEuros);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioRadioButton";
            this.Text = "frmCambioRadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorEuros;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSek;
        private System.Windows.Forms.RadioButton rbIene;
        private System.Windows.Forms.RadioButton rbLibra;
        private System.Windows.Forms.RadioButton rbDollar;
    }
}