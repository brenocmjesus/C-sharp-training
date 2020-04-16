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
    public partial class frmCambioRadioButton : Form
    {
        public frmCambioRadioButton()
        {
            InitializeComponent();
            
            //Inicializar a label para não mostrar texto no início
            lblResultado.Text = "";

            //Selecionar o radioButton Dollar por defeito no início
            rbDollar.Checked = true;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //Ler o valor da TextBox
            double valor = double.Parse(txtValorEuros.Text);

            double resultado = 0.0;
            string moeda = "";
            //Verificar qual o radioButton selecionado
            if(rbDollar.Checked == true)
            {
                //Está Dollar selecionado
                resultado = valor * Properties.Settings.Default.cambio_dollar;
                moeda = "Dollar";
            }
            if(rbLibra.Checked == true)
            {
                //Está Libra selecionado
                resultado = valor * Properties.Settings.Default.cambio_libra;
                moeda = "Libra";
            }
            if (rbIene.Checked == true)
            {
                //Está Iéne selecionado
                resultado = valor * Properties.Settings.Default.cambio_iene;
                moeda = "Iéne";
            }
            if (rbSek.Checked == true)
            {
                //Está SEK selecionado
                resultado = valor * Properties.Settings.Default.cambio_sek;
                moeda = "SEK";
            }

            //Escrever o resultado na label
            lblResultado.Text = $"{Math.Round(resultado, 2)} {moeda}";

            //Outra forma de formatar o texto da label resultado
            //lblResultado.Text = Math.Round(resultado, 2) + " " + moeda;
        }
    }
}
