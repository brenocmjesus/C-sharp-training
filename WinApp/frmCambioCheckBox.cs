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
    public partial class frmCambioCheckBox : Form
    {
        public frmCambioCheckBox()
        {
            InitializeComponent();

            //Limpar o texto da label no início
            lblResultado.Text = "";
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //Por cada vez que se clica em Converter, reinicializar o 
            //texto da label a vazio
            lblResultado.Text = "";

            //Ler o valor da TextBox
            double valor = double.Parse(txtValorEuros.Text);

            double resultado = 0.0;
            //Verificar quais as checkBox selecionadas
            if (cbDollar.Checked == true)
            {
                //Está Dollar selecionado
                resultado = valor * Properties.Settings.Default.cambio_dollar;

                //Escrever já o resultado na label
                lblResultado.Text = $"{Math.Round(resultado, 2)} Dollar\n";
            }
            if (cbLibra.Checked == true)
            {
                //Está Libra selecionado
                resultado = valor * Properties.Settings.Default.cambio_libra;

                //Escrever já o resultado na label, concatenando ao texto
                //que a label possa eventualmente já ter (usando o operador +=)
                lblResultado.Text += $"{Math.Round(resultado, 2)} Libra\n";
            }
            if (cbIene.Checked == true)
            {
                //Está Iéne selecionado
                resultado = valor * Properties.Settings.Default.cambio_iene;

                //Escrever já o resultado na label, concatenando ao texto
                //que a label possa eventualmente já ter (usando o operador +=)
                lblResultado.Text += $"{Math.Round(resultado, 2)} Iéne\n";
            }
            if (cbSek.Checked == true)
            {
                //Está SEK selecionado
                resultado = valor * Properties.Settings.Default.cambio_sek;

                //Escrever já o resultado na label, concatenando ao texto
                //que a label possa eventualmente já ter (usando o operador +=)
                lblResultado.Text += $"{Math.Round(resultado, 2)} SEK\n";
            }
        }
    }
}
