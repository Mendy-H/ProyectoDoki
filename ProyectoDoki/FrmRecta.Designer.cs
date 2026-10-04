namespace ProyectoDoki
{
    partial class FrmRecta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cmbTipo = new ComboBox();
            lblV1 = new Label();
            lblV3 = new Label();
            lblV2 = new Label();
            lblV4 = new Label();
            txtV1 = new TextBox();
            txtV3 = new TextBox();
            txtV2 = new TextBox();
            txtV4 = new TextBox();
            btnCalcular = new Button();
            lblPendiente = new Label();
            lblEcuacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 32);
            label1.Name = "label1";
            label1.Size = new Size(79, 26);
            label1.TabIndex = 3;
            label1.Text = "RECTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 96);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 4;
            label2.Text = "Tipo de recta";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.PaleGreen;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Dos puntos", "Punto y pendiente", "Pendiente y ordenada (y = mx + b)", "Forma general (Ax + By + C = 0)", "Forma simétrica (x/a + y/b = 1)" });
            cmbTipo.Location = new Point(162, 151);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(278, 33);
            cmbTipo.TabIndex = 5;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblV1
            // 
            lblV1.AutoSize = true;
            lblV1.BackColor = Color.PaleGoldenrod;
            lblV1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV1.Location = new Point(79, 228);
            lblV1.Name = "lblV1";
            lblV1.Size = new Size(35, 30);
            lblV1.TabIndex = 6;
            lblV1.Text = "x1";
            // 
            // lblV3
            // 
            lblV3.AutoSize = true;
            lblV3.BackColor = Color.PaleGoldenrod;
            lblV3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV3.ForeColor = Color.Black;
            lblV3.Location = new Point(79, 316);
            lblV3.Name = "lblV3";
            lblV3.Size = new Size(35, 30);
            lblV3.TabIndex = 7;
            lblV3.Text = "x2";
            // 
            // lblV2
            // 
            lblV2.AutoSize = true;
            lblV2.BackColor = Color.PaleGoldenrod;
            lblV2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV2.Location = new Point(376, 228);
            lblV2.Name = "lblV2";
            lblV2.Size = new Size(36, 30);
            lblV2.TabIndex = 8;
            lblV2.Text = "y1";
            // 
            // lblV4
            // 
            lblV4.AutoSize = true;
            lblV4.BackColor = Color.PaleGoldenrod;
            lblV4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV4.Location = new Point(376, 316);
            lblV4.Name = "lblV4";
            lblV4.Size = new Size(36, 30);
            lblV4.TabIndex = 9;
            lblV4.Text = "y2";
            // 
            // txtV1
            // 
            txtV1.Location = new Point(126, 229);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(150, 31);
            txtV1.TabIndex = 10;
            // 
            // txtV3
            // 
            txtV3.Location = new Point(126, 317);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(150, 31);
            txtV3.TabIndex = 11;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(427, 227);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(150, 31);
            txtV2.TabIndex = 12;
            // 
            // txtV4
            // 
            txtV4.Location = new Point(427, 315);
            txtV4.Name = "txtV4";
            txtV4.Size = new Size(150, 31);
            txtV4.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Plum;
            btnCalcular.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(268, 367);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(163, 56);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPendiente
            // 
            lblPendiente.AutoSize = true;
            lblPendiente.BackColor = Color.DarkKhaki;
            lblPendiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendiente.Location = new Point(268, 441);
            lblPendiente.Name = "lblPendiente";
            lblPendiente.Size = new Size(0, 28);
            lblPendiente.TabIndex = 15;
            // 
            // lblEcuacion
            // 
            lblEcuacion.AutoSize = true;
            lblEcuacion.BackColor = Color.DarkKhaki;
            lblEcuacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcuacion.Location = new Point(278, 497);
            lblEcuacion.Name = "lblEcuacion";
            lblEcuacion.Size = new Size(0, 28);
            lblEcuacion.TabIndex = 16;
            // 
            // FrmRecta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 542);
            Controls.Add(lblEcuacion);
            Controls.Add(lblPendiente);
            Controls.Add(btnCalcular);
            Controls.Add(txtV4);
            Controls.Add(txtV2);
            Controls.Add(txtV3);
            Controls.Add(txtV1);
            Controls.Add(lblV4);
            Controls.Add(lblV2);
            Controls.Add(lblV3);
            Controls.Add(lblV1);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRecta";
            Text = "Recta";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(cmbTipo, 0);
            Controls.SetChildIndex(lblV1, 0);
            Controls.SetChildIndex(lblV3, 0);
            Controls.SetChildIndex(lblV2, 0);
            Controls.SetChildIndex(lblV4, 0);
            Controls.SetChildIndex(txtV1, 0);
            Controls.SetChildIndex(txtV3, 0);
            Controls.SetChildIndex(txtV2, 0);
            Controls.SetChildIndex(txtV4, 0);
            Controls.SetChildIndex(btnCalcular, 0);
            Controls.SetChildIndex(lblPendiente, 0);
            Controls.SetChildIndex(lblEcuacion, 0);
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTipo;
        private Label lblV1;
        private Label lblV3;
        private Label lblV2;
        private Label lblV4;
        private TextBox txtV1;
        private TextBox txtV3;
        private TextBox txtV2;
        private TextBox txtV4;
        private Button btnCalcular;
        private Label lblPendiente;
        private Label lblEcuacion;
    }
}