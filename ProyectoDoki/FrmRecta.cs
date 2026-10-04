namespace ProyectoDoki
{
    public partial class FrmRecta : FrmBase
    {
        public FrmRecta()
        {
            InitializeComponent();
            cmbTipo.SelectedIndex = 0;
        }

        private void FrmRecta_Load(object sender, EventArgs e)
        {
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nombres = { "", "", "", "" };
            switch (cmbTipo.SelectedIndex)
            {
                case 0: nombres = new[] { "x1", "y1", "x2", "y2" }; break;
                case 1: nombres = new[] { "x1", "y1", "m", "" }; break;
                case 2: nombres = new[] { "m", "b", "", "" }; break;
                case 3: nombres = new[] { "A", "B", "C", "" }; break;
                case 4: nombres = new[] { "a (en x)", "b (en y)", "", "" }; break;
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
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = double.Parse(txtV1.Text);
                double v2 = double.Parse(txtV2.Text);
                double v3 = txtV3.Visible ? double.Parse(txtV3.Text) : 0;
                double v4 = txtV4.Visible ? double.Parse(txtV4.Text) : 0;
                Recta r;

                switch (cmbTipo.SelectedIndex)
                {
                    case 0: r = Recta.DosPuntos(v1, v2, v3, v4); break;
                    case 1: r = Recta.PuntoPendiente(v1, v2, v3); break;
                    case 2: r = Recta.PendienteOrdenada(v1, v2); break;
                    case 3: r = Recta.General(v1, v2, v3); break;
                    case 4:
                        if (v1 == 0 || v2 == 0)
                        {
                            MessageBox.Show("a y b deben ser distintos de 0");
                            return;
                        }
                        r = Recta.Simetrica(v1, v2);
                        break;
                    default:
                        MessageBox.Show("Elige un tipo de recta");
                        return;
                }

                if (!r.EsValida())
                {
                    MessageBox.Show("Con esos datos no se forma una recta");
                    return;
                }

                lblEcuacion.Text = $"General: {r.A}x + ({r.B})y + ({r.C}) = 0";
                lblPendiente.Text = r.EsVertical()
                    ? "Pendiente: indefinida (vertical)"
                    : $"m = {Math.Round(r.Pendiente(), 2)}, b = {Math.Round(r.Ordenada(), 2)}";
            }
            catch
            {
                MessageBox.Show("Elige un tipo e ingresa números en los campos");
            }
        }
    }
}