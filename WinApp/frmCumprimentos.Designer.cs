namespace WinApp
{
    partial class frmCumprimentos
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
            this.txtTipoCumprimento = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTipoCumprimento
            // 
            this.txtTipoCumprimento.Location = new System.Drawing.Point(12, 12);
            this.txtTipoCumprimento.Name = "txtTipoCumprimento";
            this.txtTipoCumprimento.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCumprimento.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(119, 24);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(75, 23);
            this.btnClique.TabIndex = 2;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(119, 156);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(11, 120);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(29, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "label";
            // 
            // Cumprimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 191);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtTipoCumprimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnClique);
            this.Name = "Cumprimentos";
            this.Text = "Cumprimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoCumprimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
    }
}