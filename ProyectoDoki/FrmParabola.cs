using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System;
using System.Windows.Forms;

namespace ProyectoDoki
{
    public partial class FrmParabola : FrmBase
    {
        public FrmParabola()
        {
            InitializeComponent();

            if (cmbTipo.Items.Count > 0)
                cmbTipo.SelectedIndex = 0;

            lblEcuacionOrdinaria.Visible = false;
            lblEcuacionGeneral.Visible = false;
        }

        private void FrmParabola_Load(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nombres = { "h (Vértice x)", "k (Vértice y)", "Dist. Focal (p)", "" };

            Label[] lbls = { lblV1, lblV2, lblV3, lblV4 };
            TextBox[] txts = { txtV1, txtV2, txtV3, txtV4 };

            for (int i = 0; i < 4; i++)
            {
                lbls[i].Text = nombres[i];
                lbls[i].Visible = nombres[i] != "";
                txts[i].Visible = nombres[i] != "";
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

                if (v3 <= 0)
                {
                    MessageBox.Show("La distancia focal (p) debe ser un valor mayor a cero.");
                    return;
                }

                Parabola parabola;

                switch (cmbTipo.SelectedIndex)
                {
                    case 0:
                        parabola = Parabola.Arriba(v1, v2, v3);
                        break;
                    case 1: 
                        parabola = Parabola.Abajo(v1, v2, v3);
                        break;
                    case 2: 
                        parabola = Parabola.Derecha(v1, v2, v3);
                        break;
                    case 3: 
                        parabola = Parabola.Izquierda(v1, v2, v3);
                        break;
                    default:
                        MessageBox.Show("Elige hacia dónde abre la parábola");
                        return;
                }

                lblEcuacionOrdinaria.Text = $"Ordinaria: {parabola.EcuacionOrdinaria()}";
                lblEcuacionGeneral.Text = $"General: {parabola.EcuacionGeneral()}";

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