namespace ProyectoDoki
{
    partial class FrmParabola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            cmbTipo = new ComboBox();
            lblV4 = new Label();
            lblV3 = new Label();
            lblV2 = new Label();
            lblV1 = new Label();
            txtV4 = new TextBox();
            txtV3 = new TextBox();
            txtV2 = new TextBox();
            txtV1 = new TextBox();
            btnCalcular = new Button();
            lblEcuacionGeneral = new Label();
            lblEcuacionOrdinaria = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Sitka Banner", 10F);
            label2.Location = new Point(221, 45);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 25;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 24;
            label1.Text = "PARABOLA";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Vertical (Abre hacia arriba)", "Vertical (Abre hacia abajo)", "Horizontal (Abre hacia la derecha)", "Horizontal (Abre hacia la izquierda)" });
            cmbTipo.Location = new Point(190, 68);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(220, 23);
            cmbTipo.TabIndex = 26;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblV4
            // 
            lblV4.AutoSize = true;
            lblV4.BackColor = Color.PaleGoldenrod;
            lblV4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV4.Location = new Point(267, 166);
            lblV4.Margin = new Padding(2, 0, 2, 0);
            lblV4.Name = "lblV4";
            lblV4.Size = new Size(0, 20);
            lblV4.TabIndex = 34;
            // 
            // lblV3
            // 
            lblV3.AutoSize = true;
            lblV3.BackColor = Color.PaleGoldenrod;
            lblV3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV3.ForeColor = Color.Black;
            lblV3.Location = new Point(31, 183);
            lblV3.Margin = new Padding(2, 0, 2, 0);
            lblV3.Name = "lblV3";
            lblV3.Size = new Size(0, 20);
            lblV3.TabIndex = 33;
            // 
            // lblV2
            // 
            lblV2.AutoSize = true;
            lblV2.BackColor = Color.PaleGoldenrod;
            lblV2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV2.Location = new Point(267, 115);
            lblV2.Margin = new Padding(2, 0, 2, 0);
            lblV2.Name = "lblV2";
            lblV2.Size = new Size(0, 20);
            lblV2.TabIndex = 32;
            // 
            // lblV1
            // 
            lblV1.AutoSize = true;
            lblV1.BackColor = Color.PaleGoldenrod;
            lblV1.Font = new Font("Segoe UI", 11F);
            lblV1.Location = new Point(41, 115);
            lblV1.Name = "lblV1";
            lblV1.Size = new Size(0, 20);
            lblV1.TabIndex = 31;
            // 
            // txtV4
            // 
            txtV4.Location = new Point(358, 180);
            txtV4.Margin = new Padding(2);
            txtV4.Name = "txtV4";
            txtV4.Size = new Size(106, 23);
            txtV4.TabIndex = 30;
            txtV4.Visible = false;
            // 
            // txtV3
            // 
            txtV3.Location = new Point(139, 180);
            txtV3.Margin = new Padding(2);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(106, 23);
            txtV3.TabIndex = 29;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(358, 112);
            txtV2.Margin = new Padding(2);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(106, 23);
            txtV2.TabIndex = 28;
            // 
            // txtV1
            // 
            txtV1.Location = new Point(139, 112);
            txtV1.Margin = new Padding(2);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(106, 23);
            txtV1.TabIndex = 27;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Plum;
            btnCalcular.Font = new Font("Cambria", 11F, FontStyle.Bold);
            btnCalcular.Location = new Point(248, 217);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 39);
            btnCalcular.TabIndex = 35;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblEcuacionGeneral
            // 
            lblEcuacionGeneral.AutoSize = true;
            lblEcuacionGeneral.BackColor = Color.DarkKhaki;
            lblEcuacionGeneral.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEcuacionGeneral.Location = new Point(161, 301);
            lblEcuacionGeneral.Name = "lblEcuacionGeneral";
            lblEcuacionGeneral.Size = new Size(0, 19);
            lblEcuacionGeneral.TabIndex = 37;
            // 
            // lblEcuacionOrdinaria
            // 
            lblEcuacionOrdinaria.AutoSize = true;
            lblEcuacionOrdinaria.BackColor = Color.DarkKhaki;
            lblEcuacionOrdinaria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEcuacionOrdinaria.Location = new Point(161, 262);
            lblEcuacionOrdinaria.Name = "lblEcuacionOrdinaria";
            lblEcuacionOrdinaria.Size = new Size(0, 19);
            lblEcuacionOrdinaria.TabIndex = 36;
            lblEcuacionOrdinaria.Visible = false;
            // 
            // FrmParabola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 334);
            Controls.Add(lblEcuacionGeneral);
            Controls.Add(lblEcuacionOrdinaria);
            Controls.Add(btnCalcular);
            Controls.Add(lblV4);
            Controls.Add(lblV3);
            Controls.Add(lblV2);
            Controls.Add(lblV1);
            Controls.Add(txtV4);
            Controls.Add(txtV3);
            Controls.Add(txtV2);
            Controls.Add(txtV1);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "FrmParabola";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmParabola";
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(cmbTipo, 0);
            Controls.SetChildIndex(txtV1, 0);
            Controls.SetChildIndex(txtV2, 0);
            Controls.SetChildIndex(txtV3, 0);
            Controls.SetChildIndex(txtV4, 0);
            Controls.SetChildIndex(lblV1, 0);
            Controls.SetChildIndex(lblV2, 0);
            Controls.SetChildIndex(lblV3, 0);
            Controls.SetChildIndex(lblV4, 0);
            Controls.SetChildIndex(btnCalcular, 0);
            Controls.SetChildIndex(lblEcuacionOrdinaria, 0);
            Controls.SetChildIndex(lblEcuacionGeneral, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cmbTipo;
        private Label lblV4;
        private Label lblV3;
        private Label lblV2;
        private Label lblV1;
        private TextBox txtV4;
        private TextBox txtV3;
        private TextBox txtV2;
        private TextBox txtV1;
        private Button btnCalcular;
        private Label lblEcuacionGeneral;
        private Label lblEcuacionOrdinaria;
    }
}