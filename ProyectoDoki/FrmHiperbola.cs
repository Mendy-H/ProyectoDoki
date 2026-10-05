using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace ProyectoDoki
{
    public partial class FrmHiperbola : FrmBase
    {
        public FrmHiperbola()
        {
            InitializeComponent();

            if (cmbTipo.Items.Count > 0)
                cmbTipo.SelectedIndex = 0;

            lblEcuacionOrdinaria.Visible = false;
            lblEcuacionGeneral.Visible = false;
        }

        private void FrmHiperbola_Load(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nombres = { "h (Centro x)", "k (Centro y)", "Semieje\nReal (a)", "Semieje\nImag. (b)" };

            Label[] lbls = { lblV1, lblV2, lblV3, lblV4 };
            TextBox[] txts = { txtV1, txtV2, txtV3, txtV4 };

            for (int i = 0; i < 4; i++)
            {
                lbls[i].Text = nombres[i];
                lbls[i].Visible = true;
                txts[i].Visible = true;
                txts[i].Clear();
            }

            lblEcuacionOrdinaria.Visible = false;
            lblEcuacionGeneral.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = double.Parse(txtV1.Text);
                double v2 = double.Parse(txtV2.Text);
                double v3 = double.Parse(txtV3.Text);
                double v4 = double.Parse(txtV4.Text);

                if (v3 <= 0 || v4 <= 0)
                {
                    MessageBox.Show("Las medidas de los semiejes (a y b) deben ser mayores a cero.");
                    return;
                }

                Hiperbola hiperbola;

                switch (cmbTipo.SelectedIndex)
                {
                    case 0:
                        hiperbola = Hiperbola.Horizontal(v1, v2, v3, v4);
                        break;
                    case 1:
                        hiperbola = Hiperbola.Vertical(v1, v2, v3, v4);
                        break;
                    default:
                        MessageBox.Show("Elige la orientación de la hipérbola");
                        return;
                }

                lblEcuacionOrdinaria.Text = $"Ordinaria: {hiperbola.EcuacionOrdinaria()}";
                lblEcuacionGeneral.Text = $"General: {hiperbola.EcuacionGeneral()}";

                lblEcuacionOrdinaria.Visible = true;
                lblEcuacionGeneral.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa solo números válidos en todos los campos.");
            }
        }
    }
}