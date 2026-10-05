using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDoki
{
    public partial class FrmElipse : FrmBase
    {
        public FrmElipse()
        {
            InitializeComponent();

            if (cmbTipo.Items.Count > 0)
                cmbTipo.SelectedIndex = 0;

            lblEcuacionOrdinaria.Visible = false;
            lblEcuacionGeneral.Visible = false;
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nombres = { "h (Centro x)", "k (Centro y)", "Semieje\nMayor (a)", "Semieje\nMenor (b)" };

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
                if (v3 <= v4)
                {
                    MessageBox.Show("En una elipse, el Semieje Mayor (a) debe ser un número más grande que el Semieje Menor (b).");
                    return;
                }

                Elipse elipse;

                switch (cmbTipo.SelectedIndex)
                {
                    case 0: 
                        elipse = Elipse.Horizontal(v1, v2, v3, v4);
                        break;
                    case 1: 
                        elipse = Elipse.Vertical(v1, v2, v3, v4);
                        break;
                    default:
                        MessageBox.Show("Elige la orientación de la elipse");
                        return;
                }

                lblEcuacionOrdinaria.Text = $"Ordinaria: {elipse.EcuacionOrdinaria()}";
                lblEcuacionGeneral.Text = $"General: {elipse.EcuacionGeneral()}";

                lblEcuacionOrdinaria.Visible = true;
                lblEcuacionGeneral.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa solo números válidos en todos los campos.");
            }
        }

        private void FrmElipse_Load_1(object sender, EventArgs e)
        {

        }
    }
}