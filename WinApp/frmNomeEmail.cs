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
    public partial class frmNomeEmail : Form
    {
        /*************************************
         * Inicializar uma sting sem dar valor inicial
         * string x;
         * 
         * Inicializar uma string dando um valor inicial
         * string x = "abc";
         * 
         * Dar um valor a uma string usando composição com concatenação
         * string variavelY = " muito ";
         * string x = "Eu gosto" + variavelY + "da cor vermelha";
         * 
         * Dar um valor a uma string usando composição com variáveis usando $ e {}
         * string variavelY = " muito ";
         * string x = $"Eu gosto {variavelY} da cor vermelha";
         * 
         * Criar uma string em 'modo texto' ou seja, com múltiplas linhas
         * string x = @"Isto é um texto muito longo e 
         *              com muitas quebras de linha que 
         *              só é possível fazer porque colocamos 
         *              o @ no início";
         * 
         * ************************************/

        public frmNomeEmail()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Ler o nome completo
            string nomeCompleto = txtNomeCompleto.Text;
            //Pegar no primeiro nome e no último 
            string[] nomes = nomeCompleto.Split(' ');
            string primeiroNome = nomes[0];
            string ultimoNome = nomes[nomes.Length - 1];

            //colocar na labelresultadonome o primeiro e último nomes em maiúsculas
            lblRes_Nome.Text = $"{primeiroNome.ToUpper()} {ultimoNome.ToUpper()}";

            //Colocar na labelemail1 o primeiro e último nomes em minúsculas, 
            //separados por ponto e com @xpto.pt no final
            lblRes_Email1.Text = $"{primeiroNome.ToLower()}.{ultimoNome.ToLower()}@xpto.pt";

            //Colocar na labelemail2 a primeira letra do primeiro nome e o último nome, em minúsculas, 
            //e com @xpto.pt no final
            lblRes_Email2.Text = $"{primeiroNome.ToLower()[0]}{ultimoNome.ToLower()}@xpto.pt";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar a textbox
            txtNomeCompleto.Text = "";

            //Limpar as labels
            lblRes_Nome.Text = "";
            lblRes_Email1.Text = "";
            lblRes_Email2.Text = "";
        }
    }
}
