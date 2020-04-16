namespace WinApp
{
    partial class frmQuantoTempoPassou
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
            this.cal_esquerda = new System.Windows.Forms.MonthCalendar();
            this.cal_direita = new System.Windows.Forms.MonthCalendar();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_meses = new System.Windows.Forms.Label();
            this.lbl_anos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cal_esquerda
            // 
            this.cal_esquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_esquerda.Location = new System.Drawing.Point(18, 18);
            this.cal_esquerda.Name = "cal_esquerda";
            this.cal_esquerda.TabIndex = 0;
            this.cal_esquerda.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_esquerda_DateSelected);
            // 
            // cal_direita
            // 
            this.cal_direita.Location = new System.Drawing.Point(263, 18);
            this.cal_direita.Name = "cal_direita";
            this.cal_direita.TabIndex = 1;
            this.cal_direita.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cal_direita_DateSelected);
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(503, 18);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(35, 13);
            this.lbl_dias.TabIndex = 2;
            this.lbl_dias.Text = "label1";
            // 
            // lbl_meses
            // 
            this.lbl_meses.AutoSize = true;
            this.lbl_meses.Location = new System.Drawing.Point(503, 35);
            this.lbl_meses.Name = "lbl_meses";
            this.lbl_meses.Size = new System.Drawing.Size(35, 13);
            this.lbl_meses.TabIndex = 3;
            this.lbl_meses.Text = "label2";
            // 
            // lbl_anos
            // 
            this.lbl_anos.AutoSize = true;
            this.lbl_anos.Location = new System.Drawing.Point(503, 52);
            this.lbl_anos.Name = "lbl_anos";
            this.lbl_anos.Size = new System.Drawing.Size(35, 13);
            this.lbl_anos.TabIndex = 4;
            this.lbl_anos.Text = "label3";
            // 
            // frmQuantoTempoPassou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 199);
            this.Controls.Add(this.lbl_anos);
            this.Controls.Add(this.lbl_meses);
            this.Controls.Add(this.lbl_dias);
            this.Controls.Add(this.cal_direita);
            this.Controls.Add(this.cal_esquerda);
            this.Name = "frmQuantoTempoPassou";
            this.Text = "Quanto Tempo Passou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal_esquerda;
        private System.Windows.Forms.MonthCalendar cal_direita;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Label lbl_meses;
        private System.Windows.Forms.Label lbl_anos;
    }
}