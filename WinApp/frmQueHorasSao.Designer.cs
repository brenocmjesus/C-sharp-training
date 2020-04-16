namespace WinApp
{
    partial class frmQueHorasSao
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
            this.pb_horas = new System.Windows.Forms.ProgressBar();
            this.pb_minutos = new System.Windows.Forms.ProgressBar();
            this.pb_segundos = new System.Windows.Forms.ProgressBar();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.lbl_minutos = new System.Windows.Forms.Label();
            this.lbl_segundos = new System.Windows.Forms.Label();
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.rb_manual = new System.Windows.Forms.RadioButton();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pb_horas
            // 
            this.pb_horas.Location = new System.Drawing.Point(12, 12);
            this.pb_horas.Maximum = 23;
            this.pb_horas.Name = "pb_horas";
            this.pb_horas.Size = new System.Drawing.Size(249, 23);
            this.pb_horas.Step = 1;
            this.pb_horas.TabIndex = 0;
            // 
            // pb_minutos
            // 
            this.pb_minutos.Location = new System.Drawing.Point(12, 42);
            this.pb_minutos.Maximum = 59;
            this.pb_minutos.Name = "pb_minutos";
            this.pb_minutos.Size = new System.Drawing.Size(448, 23);
            this.pb_minutos.Step = 1;
            this.pb_minutos.TabIndex = 1;
            // 
            // pb_segundos
            // 
            this.pb_segundos.Location = new System.Drawing.Point(12, 72);
            this.pb_segundos.Maximum = 59;
            this.pb_segundos.Name = "pb_segundos";
            this.pb_segundos.Size = new System.Drawing.Size(448, 23);
            this.pb_segundos.Step = 1;
            this.pb_segundos.TabIndex = 2;
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.Location = new System.Drawing.Point(267, 11);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(60, 24);
            this.lbl_horas.TabIndex = 3;
            this.lbl_horas.Text = "label1";
            // 
            // lbl_minutos
            // 
            this.lbl_minutos.AutoSize = true;
            this.lbl_minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minutos.Location = new System.Drawing.Point(466, 41);
            this.lbl_minutos.Name = "lbl_minutos";
            this.lbl_minutos.Size = new System.Drawing.Size(60, 24);
            this.lbl_minutos.TabIndex = 4;
            this.lbl_minutos.Text = "label2";
            // 
            // lbl_segundos
            // 
            this.lbl_segundos.AutoSize = true;
            this.lbl_segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundos.Location = new System.Drawing.Point(466, 71);
            this.lbl_segundos.Name = "lbl_segundos";
            this.lbl_segundos.Size = new System.Drawing.Size(60, 24);
            this.lbl_segundos.TabIndex = 5;
            this.lbl_segundos.Text = "label3";
            // 
            // rb_auto
            // 
            this.rb_auto.AutoSize = true;
            this.rb_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_auto.Location = new System.Drawing.Point(12, 101);
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.Size = new System.Drawing.Size(122, 28);
            this.rb_auto.TabIndex = 6;
            this.rb_auto.Text = "Automático";
            this.rb_auto.UseVisualStyleBackColor = true;
            this.rb_auto.CheckedChanged += new System.EventHandler(this.rb_auto_CheckedChanged);
            // 
            // rb_manual
            // 
            this.rb_manual.AutoSize = true;
            this.rb_manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_manual.Location = new System.Drawing.Point(12, 135);
            this.rb_manual.Name = "rb_manual";
            this.rb_manual.Size = new System.Drawing.Size(90, 28);
            this.rb_manual.TabIndex = 7;
            this.rb_manual.TabStop = true;
            this.rb_manual.Text = "Manual";
            this.rb_manual.UseVisualStyleBackColor = true;
            this.rb_manual.CheckedChanged += new System.EventHandler(this.rb_manual_CheckedChanged);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(192, 117);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(106, 40);
            this.btn_atualizar.TabIndex = 8;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // frmQueHorasSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 175);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.rb_manual);
            this.Controls.Add(this.rb_auto);
            this.Controls.Add(this.lbl_segundos);
            this.Controls.Add(this.lbl_minutos);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.pb_segundos);
            this.Controls.Add(this.pb_minutos);
            this.Controls.Add(this.pb_horas);
            this.Name = "frmQueHorasSao";
            this.Text = "Horas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_horas;
        private System.Windows.Forms.ProgressBar pb_minutos;
        private System.Windows.Forms.ProgressBar pb_segundos;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Label lbl_minutos;
        private System.Windows.Forms.Label lbl_segundos;
        private System.Windows.Forms.RadioButton rb_auto;
        private System.Windows.Forms.RadioButton rb_manual;
        private System.Windows.Forms.Button btn_atualizar;
    }
}