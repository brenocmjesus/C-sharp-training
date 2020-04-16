namespace WinApp
{
    partial class frmCambioCheckBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSek = new System.Windows.Forms.CheckBox();
            this.cbIene = new System.Windows.Forms.CheckBox();
            this.cbLibra = new System.Windows.Forms.CheckBox();
            this.cbDollar = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtValorEuros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSek);
            this.groupBox1.Controls.Add(this.cbIene);
            this.groupBox1.Controls.Add(this.cbLibra);
            this.groupBox1.Controls.Add(this.cbDollar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // cbSek
            // 
            this.cbSek.AutoSize = true;
            this.cbSek.Location = new System.Drawing.Point(6, 131);
            this.cbSek.Name = "cbSek";
            this.cbSek.Size = new System.Drawing.Size(66, 28);
            this.cbSek.TabIndex = 3;
            this.cbSek.Text = "SEK";
            this.cbSek.UseVisualStyleBackColor = true;
            // 
            // cbIene
            // 
            this.cbIene.AutoSize = true;
            this.cbIene.Location = new System.Drawing.Point(6, 97);
            this.cbIene.Name = "cbIene";
            this.cbIene.Size = new System.Drawing.Size(66, 28);
            this.cbIene.TabIndex = 2;
            this.cbIene.Text = "Iéne";
            this.cbIene.UseVisualStyleBackColor = true;
            // 
            // cbLibra
            // 
            this.cbLibra.AutoSize = true;
            this.cbLibra.Location = new System.Drawing.Point(6, 63);
            this.cbLibra.Name = "cbLibra";
            this.cbLibra.Size = new System.Drawing.Size(70, 28);
            this.cbLibra.TabIndex = 1;
            this.cbLibra.Text = "Libra";
            this.cbLibra.UseVisualStyleBackColor = true;
            // 
            // cbDollar
            // 
            this.cbDollar.AutoSize = true;
            this.cbDollar.Location = new System.Drawing.Point(7, 29);
            this.cbDollar.Name = "cbDollar";
            this.cbDollar.Size = new System.Drawing.Size(77, 28);
            this.cbDollar.TabIndex = 0;
            this.cbDollar.Text = "Dollar";
            this.cbDollar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 128);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 24);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "label2";
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(12, 78);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(150, 39);
            this.btnConverter.TabIndex = 7;
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
            this.txtValorEuros.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor em €";
            // 
            // frmCambioCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorEuros);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioCheckBox";
            this.Text = "frmCambioCheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSek;
        private System.Windows.Forms.CheckBox cbIene;
        private System.Windows.Forms.CheckBox cbLibra;
        private System.Windows.Forms.CheckBox cbDollar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtValorEuros;
        private System.Windows.Forms.Label label1;
    }
}