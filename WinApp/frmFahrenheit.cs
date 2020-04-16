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
    public partial class frmFahrenheit : Form
    {
        public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double f = double.Parse(txtFahrenheit.Text);

            double c = (f - 32) / 1.8;

            txtCelsius.Text = Math.Round(c, 2).ToString();
        }

        private void btnNovoCalculo_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Text = "";
            txtCelsius.Text = "";
        }
    }
}
