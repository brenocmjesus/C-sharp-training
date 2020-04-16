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
    public partial class frmNotaFinal : Form
    {
        public frmNotaFinal()
        {
            InitializeComponent();
            this.Height = 310;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Calcular a nota final
            //NotaFinal = (peso1 x (notaTeste1 + notaTeste2)/2) +
            //            (peso2 x(notaTrabalho1 + notaTrabalho2) / 2) +
            //            (peso3 x notaTrabalhoFinal)
            //peso1 = 65%, peso2 = 15% e peso3 = 20%

            double NotaFinal, notaTeste1, notaTeste2,
                   notaTrabalho1, notaTrabalho2, notaTrabalhoFinal;
            //double peso1 = 0.65, peso2 = 0.15, peso3 = 0.2;

            notaTeste1 = double.Parse(txt_teste1.Text);
            notaTeste2 = double.Parse(txt_teste2.Text);
            notaTrabalho1 = double.Parse(txt_trab1.Text);
            notaTrabalho2 = double.Parse(txt_trab2.Text);
            notaTrabalhoFinal = double.Parse(txt_trabFinal.Text);



            NotaFinal = (Properties.Settings.Default.peso1 * (notaTeste1 + notaTeste2) / 2) +
                         (Properties.Settings.Default.peso2 * (notaTrabalho1 + notaTrabalho2) / 2) +
                         (Properties.Settings.Default.peso3 * notaTrabalhoFinal);

            //Arredondar o resultado a 0 casas decimais
            NotaFinal = Math.Round(NotaFinal, 0);

            lblResultado.Text = $"A nota final é: {NotaFinal} valores";

            this.Height = 420;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Colocar os textos das textbox a vazio
            txt_teste1.Text = "";
            txt_teste2.Text = "";
            txt_trab1.Text = "";
            txt_trab2.Text = "";
            txt_trabFinal.Text = "";
            //Colocar o texto da label a vazio
            lblResultado.Text = "";
            //Reduzir a janela
            this.Height = 310;
        }
    }
}
