namespace WinApp
{
    partial class frmFahrenheit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovoCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.Location = new System.Drawing.Point(163, 27);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(284, 38);
            this.txtFahrenheit.TabIndex = 2;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsius.Location = new System.Drawing.Point(163, 175);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.ReadOnly = true;
            this.txtCelsius.Size = new System.Drawing.Size(284, 38);
            this.txtCelsius.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(163, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(284, 48);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovoCalculo
            // 
            this.btnNovoCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCalculo.Location = new System.Drawing.Point(163, 242);
            this.btnNovoCalculo.Name = "btnNovoCalculo";
            this.btnNovoCalculo.Size = new System.Drawing.Size(284, 48);
            this.btnNovoCalculo.TabIndex = 5;
            this.btnNovoCalculo.Text = "Novo Cálculo";
            this.btnNovoCalculo.UseVisualStyleBackColor = true;
            this.btnNovoCalculo.Click += new System.EventHandler(this.btnNovoCalculo_Click);
            // 
            // frmFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 312);
            this.Controls.Add(this.btnNovoCalculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFahrenheit";
            this.Text = "frmFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovoCalculo;
    }
}