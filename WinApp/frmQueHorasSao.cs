using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmQueHorasSao : Form
    {
        //Variável do tipo Timer. Também denominada por variável global
        //porque foi criada dentro da classe frmQueHorasSao MAS FORA de 
        //todos os métodos da classe
        //Desta forma, esta variável pode ser acedida a partir de qualquer método
        //de uma manira "global". Daí o nome "variável global"
        Timer t;
        public frmQueHorasSao()
        {
            InitializeComponent();

            //Inicializar o timer t "variável global"
            t = new Timer();
            t.Interval = 1000;
            t.Tick += T_Tick;

            //Colocar o radiobutton automatico checked
            rb_auto.Checked = true;
            //Colocar o button atualizar inativo
            btn_atualizar.Enabled = false;

            //texto das 3 labels vazio
            lbl_horas.Text = "";
            lbl_minutos.Text = "";
            lbl_segundos.Text = "";
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            ColocarHorasMinutosSegundos();
        }
        private void rb_auto_CheckedChanged(object sender, EventArgs e)
        {
            //se o radiobutton automatico está checked
            //colocar o button atualizar inativo
            if (rb_auto.Checked == true)
                btn_atualizar.Enabled = false;

            //se o radiobutton automatico está checked
            //colocar as horas, minutos e segundos de forma automática
            if(rb_auto.Checked == true)
            {
                //Arrancar com o timer
                t.Start();
            }
        }
        private void T_Tick(object sender, EventArgs e)
        {
            //Escrever as horas, minutos e segundos nas barras e nas labels
            ColocarHorasMinutosSegundos();
        }
        private void rb_manual_CheckedChanged(object sender, EventArgs e)
        {
            //se o radiobutton manual está checked
            //colocar o button atualizar ativo
            if (rb_manual.Checked == true)
                btn_atualizar.Enabled = true;

            //se  radiobutton manual stá checked
            //parar o timer
            if(rb_manual.Checked == true)
            {
                //Parar o timer
                t.Stop();
            }
        }
        private void ColocarHorasMinutosSegundos()
        {
            //Criar 3 variáveis para guardar as horas, minutos e segundos
            int horas, minutos, segundos;

            //Ir à data atual do sistema (DateTime.Now) e ler as horas
            horas = DateTime.Now.Hour;
            //Ir à data atual do sistema (DateTime.Now) e ler os minutos
            minutos = DateTime.Now.Minute;
            //Ir à data atual do sistema (DateTime.Now) e ler os segundos
            segundos = DateTime.Now.Second;

            //Colocar os 3 valores nas 3 progressbar
            pb_horas.Value = horas;
            pb_minutos.Value = minutos;
            pb_segundos.Value = segundos;

            //Colocar os textos nas 3 labels
            lbl_horas.Text = horas + " horas";
            lbl_minutos.Text = minutos + " minutos";
            lbl_segundos.Text = segundos + " segundos";
        }
    }
}
