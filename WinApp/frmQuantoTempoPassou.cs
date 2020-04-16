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
    public partial class frmQuantoTempoPassou : Form
    {
        public frmQuantoTempoPassou()
        {
            InitializeComponent();

            //Apagar o texto das labels
            lbl_dias.Text = "";
            lbl_meses.Text = "";
            lbl_anos.Text = "";

            //O calendario da esquerda apenas pode mostrar datas 
            //anteriores à data atual
            cal_esquerda.MaxDate = DateTime.Now;
            cal_esquerda.MaxSelectionCount = 1;//Apenas deixa selecionar 1 dia de cada vez

            //O calendario da direita apenas pode mostrar datas 
            //posteriores à data atual
            cal_direita.MinDate = DateTime.Now;
            cal_direita.MaxSelectionCount = 1;//Apenas deixa selecionar 1 dia de cada vez
        }

        private void cal_esquerda_DateSelected(object sender, DateRangeEventArgs e)
        {
            CalcularDatas();
        }

        private void cal_direita_DateSelected(object sender, DateRangeEventArgs e)
        {
            CalcularDatas();
        }

        private void CalcularDatas()
        {
            //Ler as datas nos 2 calendários
            DateTime dataEsquerda = cal_esquerda.SelectionStart;
            DateTime dataDireita = cal_direita.SelectionStart;

            //****************************************************
            //Calcular a diferença em dias entre os 2 calendários
            TimeSpan ts = dataDireita - dataEsquerda;
            int dias = ts.Days;
            //****************************************************


            //****************************************************
            //Calcular a diferença em meses entre os 2 calendários
            int meses = ((dataDireita.Year - dataEsquerda.Year) * 12) +
                            (dataDireita.Month - dataEsquerda.Month);

            //1-11-2020     1-12-2020   12-11 = 1
            // (anoMaior - anoMenor) * 12 = 0
            // ((anoMaior - anoMenor) * 12 ) + (mesDireita - mesEsquerda) = 
            //                  0            +              1             = 1


            //1-11-2019     1-12-2020   12-11 = 1
            // (anoMaior - anoMenor) * 12 = 12
            // ((anoMaior - anoMenor) * 12 ) + (mesDireita - mesEsquerda) = 
            //                  12           +              1             = 13
            //****************************************************

            //****************************************************
            //Calcular a diferença em anos entre os 2 calendários
            int anos = dataDireita.Year - dataEsquerda.Year;
            //****************************************************


            //Escrever nas labels
            lbl_dias.Text = dias + " dias";
            lbl_meses.Text = meses + " meses";
            lbl_anos.Text = anos + " anos";

        }
    }
}
