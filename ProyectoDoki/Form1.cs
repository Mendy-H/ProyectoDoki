using System;
using System.Windows.Forms;

namespace ProyectoDoki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form frm = null;
            switch (cmbOpciones.SelectedItem?.ToString())
            {
                case "Recta":
                    frm = new FrmRecta();
                    break;
                case "Circunferencia":
                    frm = new FrmCircunferencia();
                    break;
                case "Elipse":
                    frm = new FrmElipse();
                    break;
                case "Parábola":
                    frm = new FrmParabola();
                    break;
                case "Hipérbola":
                    frm = new FrmHiperbola();
                    break;
                case "Ecuación General":
                    frm = new FrmEcuGral();
                    break;
                default:
                    MessageBox.Show("Elige una opción valia");
                    return;
            }

            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola :D\n Este programa fue creado por Donovan y Wendy\n EQUIPO DOKI\n ", "Acerca de Doki's company", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
