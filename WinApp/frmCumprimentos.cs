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
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();

            //Mudar o tamanho da janela
            this.Height = 115;
        }
        public frmCumprimentos(string x) : this()//Invocar o construtor vazio
        {
            //Mudar o título da janela
            this.Text = x;
        }
        public frmCumprimentos(int x) : this("OUTRO TESTE")//Invocar o construtor que recebe uma string
        {
            
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Ler o texto da caixa txtTipoCumprimento
            string s1 = txtTipoCumprimento.Text;

            //Ler o texto da caixa txtNome
            string s2 = txtNome.Text;

            //Concatenar os 2 textos (com um espaço entre eles) 
            //e adicionar !! no fim
            string s3 = s1 + " " + s2 + "!!";

            //Colocar o resultado do texto todo na label lblResultado
            lblResultado.Text = s3;

            //Aumentar o tamanho da janela
            this.Height = 230;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Apagar o texto da label
            lblResultado.Text = string.Empty;// <=> ""
            //Apagar o texto das 2 textbox
            txtTipoCumprimento.Text = "";
            txtNome.Text = "";

            //Diminuir o tamanho da janela
            this.Height = 115;
        }
    }
}
