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
            label1.Location = new Point(271, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 3;
            label1.Text = "RECTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Tipo de recta";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.PaleGreen;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Dos puntos", "Punto y pendiente", "Pendiente y ordenada (y = mx + b)", "Forma general (Ax + By + C = 0)", "Forma simétrica (x/a + y/b = 1)" });
            cmbTipo.Location = new Point(113, 91);
            cmbTipo.Margin = new Padding(2);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(196, 23);
            cmbTipo.TabIndex = 5;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblV1
            // 
            lblV1.AutoSize = true;
            lblV1.BackColor = Color.PaleGoldenrod;
            lblV1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV1.Location = new Point(55, 137);
            lblV1.Margin = new Padding(2, 0, 2, 0);
            lblV1.Name = "lblV1";
            lblV1.Size = new Size(24, 20);
            lblV1.TabIndex = 6;
            lblV1.Text = "x1";
            lblV1.Click += lblV1_Click;
            // 
            // lblV3
            // 
            lblV3.AutoSize = true;
            lblV3.BackColor = Color.PaleGoldenrod;
            lblV3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV3.ForeColor = Color.Black;
            lblV3.Location = new Point(55, 190);
            lblV3.Margin = new Padding(2, 0, 2, 0);
            lblV3.Name = "lblV3";
            lblV3.Size = new Size(24, 20);
            lblV3.TabIndex = 7;
            lblV3.Text = "x2";
            // 
            // lblV2
            // 
            lblV2.AutoSize = true;
            lblV2.BackColor = Color.PaleGoldenrod;
            lblV2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV2.Location = new Point(263, 137);
            lblV2.Margin = new Padding(2, 0, 2, 0);
            lblV2.Name = "lblV2";
            lblV2.Size = new Size(24, 20);
            lblV2.TabIndex = 8;
            lblV2.Text = "y1";
            lblV2.Click += lblV2_Click;
            // 
            // lblV4
            // 
            lblV4.AutoSize = true;
            lblV4.BackColor = Color.PaleGoldenrod;
            lblV4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV4.Location = new Point(263, 190);
            lblV4.Margin = new Padding(2, 0, 2, 0);
            lblV4.Name = "lblV4";
            lblV4.Size = new Size(24, 20);
            lblV4.TabIndex = 9;
            lblV4.Text = "y2";
            // 
            // txtV1
            // 
            txtV1.Location = new Point(88, 137);
            txtV1.Margin = new Padding(2);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(106, 23);
            txtV1.TabIndex = 10;
            // 
            // txtV3
            // 
            txtV3.Location = new Point(88, 190);
            txtV3.Margin = new Padding(2);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(106, 23);
            txtV3.TabIndex = 11;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(299, 136);
            txtV2.Margin = new Padding(2);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(106, 23);
            txtV2.TabIndex = 12;
            // 
            // txtV4
            // 
            txtV4.Location = new Point(299, 189);
            txtV4.Margin = new Padding(2);
            txtV4.Name = "txtV4";
            txtV4.Size = new Size(106, 23);
            txtV4.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Plum;
            btnCalcular.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(188, 220);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 34);
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
            lblPendiente.Location = new Point(188, 265);
            lblPendiente.Margin = new Padding(2, 0, 2, 0);
            lblPendiente.Name = "lblPendiente";
            lblPendiente.Size = new Size(0, 19);
            lblPendiente.TabIndex = 15;
            // 
            // lblEcuacion
            // 
            lblEcuacion.AutoSize = true;
            lblEcuacion.BackColor = Color.DarkKhaki;
            lblEcuacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcuacion.Location = new Point(195, 298);
            lblEcuacion.Margin = new Padding(2, 0, 2, 0);
            lblEcuacion.Name = "lblEcuacion";
            lblEcuacion.Size = new Size(0, 19);
            lblEcuacion.TabIndex = 16;
            // 
            // FrmRecta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 325);
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
            Margin = new Padding(1);
            Name = "FrmRecta";
            StartPosition = FormStartPosition.CenterScreen;
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