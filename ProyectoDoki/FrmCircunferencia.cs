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
    public partial class FrmCircunferencia : FrmBase
    {
        public FrmCircunferencia()
        {
            InitializeComponent();
            cmbTipo.SelectedIndex = 0;

            lblEcuacionOrdinaria.Visible = false;
            lblEcuacionGeneral.Visible = false;
        }

        private void FrmCircunferencia_Load(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nombres = { "", "", "", "" };
            switch (cmbTipo.SelectedIndex)
            {
                case 0: nombres = new[] { "h (Centro x)", "k (Centro y)", "Radio (r)", "" }; break;
                case 1: nombres = new[] { "h (Centro x)", "k (Centro y)", "Punto x", "Punto y" }; break;
            }

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
                double v3 = txtV3.Visible ? double.Parse(txtV3.Text) : 0;
                double v4 = txtV4.Visible ? double.Parse(txtV4.Text) : 0;
                Circunferencia c;

                switch (cmbTipo.SelectedIndex)
                {
                    case 0:
                        if (v3 <= 0)
                        {
                            MessageBox.Show("El radio debe ser mayor a 0");
                            return;
                        }
                        c = Circunferencia.CentroYRadio(v1, v2, v3);
                        break;
                    case 1:
                        if (v1 == v3 && v2 == v4)
                        {
                            MessageBox.Show("El centro y el punto no pueden ser el mismo");
                            return;
                        }
                        c = Circunferencia.CentroYPunto(v1, v2, v3, v4);
                        break;
                    default:
                        MessageBox.Show("Elige un tipo de cálculo");
                        return;
                }

                lblEcuacionOrdinaria.Text = $"Ordinaria: {c.EcuacionOrdinaria()}";
                lblEcuacionGeneral.Text = $"General: {c.EcuacionGeneral()}";

                lblEcuacionOrdinaria.Visible = true;
                lblEcuacionGeneral.Visible = true;
            }
            catch
            {
                MessageBox.Show("Elige un tipo e ingresa números válidos en los campos");
            }
        }

        private void FrmCircunferencia_Load_1(object sender, EventArgs e)
        {

        }
    }
}