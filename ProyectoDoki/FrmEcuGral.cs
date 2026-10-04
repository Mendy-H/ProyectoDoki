using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDoki
{
    public partial class FrmEcuGral : FrmBase
    {
        public FrmEcuGral()
        {
            InitializeComponent();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIdentifica_Click(object sender, EventArgs e)
        {
            try
            {
                EcuGral ec = new EcuGral(
                    int.Parse(txtA.Text), int.Parse(txtB.Text), int.Parse(txtC.Text),
                    int.Parse(txtD.Text), int.Parse(txtE.Text), int.Parse(txtF.Text));
                lblResultado.Text = "Es una " + ec.Identifica();
            }
            catch
            {
                MessageBox.Show("Ingresa números enteros en todos los campos");
            }
        }
    }
}
