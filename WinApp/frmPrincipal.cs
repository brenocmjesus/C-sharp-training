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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSup_Fich_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSup_Exer_Cump_Click(object sender, EventArgs e)
        {
            frmCumprimentos X = new frmCumprimentos();
            X.MdiParent = this;
            X.Show();
        }

        private void mnuSup_Exer_Fahr_Click(object sender, EventArgs e)
        {
            frmFahrenheit X = new frmFahrenheit();
            X.MdiParent = this;
            X.Show();
        }

        private void mnuSup_Exer_CalcNota_Click(object sender, EventArgs e)
        {
            frmNotaFinal X = new frmNotaFinal();
            X.MdiParent = this;
            X.Show();
        }

        private void mnuSup_Jane_Casc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuSup_Jane_Hor_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuSup_Jane_Ver_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuSup_Exer_NomeEmail_Click(object sender, EventArgs e)
        {
            frmNomeEmail X = new frmNomeEmail();
            X.MdiParent = this;
            X.Show();
        }

        private void mnuSup_Exer_QueHorSao_Click(object sender, EventArgs e)
        {
            frmQueHorasSao X = new frmQueHorasSao();
            X.MdiParent = this;
            X.Show();
        }

        private void mnuSup_Exer_QuantoTempo_Click(object sender, EventArgs e)
        {
            frmQuantoTempoPassou X = new frmQuantoTempoPassou();
            X.MdiParent = this;
            X.Show();
        }

        private void mnuSup_Exer_Cambio_Radio_Click(object sender, EventArgs e)
        {
            frmCambioRadioButton f = new frmCambioRadioButton();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSup_Exer_Cambio_Check_Click(object sender, EventArgs e)
        {
            frmCambioCheckBox f = new frmCambioCheckBox();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSup_Exer_Cambio_DropDown_Click(object sender, EventArgs e)
        {
            frmCambioDropDown f = new frmCambioDropDown();
            f.MdiParent = this;
            f.Show();
        }
    }
}
