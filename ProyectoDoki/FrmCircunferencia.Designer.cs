namespace ProyectoDoki
{
    partial class FrmCircunferencia
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
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblV1 = new Label();
            lblV2 = new Label();
            lblV3 = new Label();
            lblV4 = new Label();
            txtV1 = new TextBox();
            txtV2 = new TextBox();
            txtV3 = new TextBox();
            txtV4 = new TextBox();
            btnCalcular = new Button();
            lblEcuacionOrdinaria = new Label();
            lblEcuacionGeneral = new Label();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Centro (h, k) y Radio (r)", "Centro (h, k) y Punto por donde pasa (x, y)" });
            cmbTipo.Location = new Point(186, 83);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(251, 23);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label1.Location = new Point(229, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 4;
            label1.Text = "CIRCUNFERENCIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Sitka Banner", 10F);
            label2.Location = new Point(208, 60);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 5;
            label2.Text = "Tipo";
            // 
            // lblV1
            // 
            lblV1.AutoSize = true;
            lblV1.BackColor = Color.PaleGoldenrod;
            lblV1.Font = new Font("Segoe UI", 11F);
            lblV1.Location = new Point(73, 122);
            lblV1.Name = "lblV1";
            lblV1.Size = new Size(0, 20);
            lblV1.TabIndex = 9;
            // 
            // lblV2
            // 
            lblV2.AutoSize = true;
            lblV2.BackColor = Color.PaleGoldenrod;
            lblV2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV2.Location = new Point(283, 122);
            lblV2.Margin = new Padding(2, 0, 2, 0);
            lblV2.Name = "lblV2";
            lblV2.Size = new Size(0, 20);
            lblV2.TabIndex = 9;
            // 
            // lblV3
            // 
            lblV3.AutoSize = true;
            lblV3.BackColor = Color.PaleGoldenrod;
            lblV3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV3.ForeColor = Color.Black;
            lblV3.Location = new Point(71, 175);
            lblV3.Margin = new Padding(2, 0, 2, 0);
            lblV3.Name = "lblV3";
            lblV3.Size = new Size(0, 20);
            lblV3.TabIndex = 10;
            // 
            // lblV4
            // 
            lblV4.AutoSize = true;
            lblV4.BackColor = Color.PaleGoldenrod;
            lblV4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV4.Location = new Point(283, 175);
            lblV4.Margin = new Padding(2, 0, 2, 0);
            lblV4.Name = "lblV4";
            lblV4.Size = new Size(0, 20);
            lblV4.TabIndex = 11;
            // 
            // txtV1
            // 
            txtV1.Location = new Point(164, 121);
            txtV1.Margin = new Padding(2);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(106, 23);
            txtV1.TabIndex = 12;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(373, 122);
            txtV2.Margin = new Padding(2);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(106, 23);
            txtV2.TabIndex = 13;
            // 
            // txtV3
            // 
            txtV3.Location = new Point(164, 174);
            txtV3.Margin = new Padding(2);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(106, 23);
            txtV3.TabIndex = 14;
            // 
            // txtV4
            // 
            txtV4.Location = new Point(373, 175);
            txtV4.Margin = new Padding(2);
            txtV4.Name = "txtV4";
            txtV4.Size = new Size(106, 23);
            txtV4.TabIndex = 15;
            txtV4.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Plum;
            btnCalcular.Font = new Font("Cambria", 11F, FontStyle.Bold);
            btnCalcular.Location = new Point(229, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 39);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblEcuacionOrdinaria
            // 
            lblEcuacionOrdinaria.AutoSize = true;
            lblEcuacionOrdinaria.BackColor = Color.DarkKhaki;
            lblEcuacionOrdinaria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEcuacionOrdinaria.Location = new Point(186, 268);
            lblEcuacionOrdinaria.Name = "lblEcuacionOrdinaria";
            lblEcuacionOrdinaria.Size = new Size(0, 19);
            lblEcuacionOrdinaria.TabIndex = 17;
            lblEcuacionOrdinaria.Visible = false;
            // 
            // lblEcuacionGeneral
            // 
            lblEcuacionGeneral.AutoSize = true;
            lblEcuacionGeneral.BackColor = Color.DarkKhaki;
            lblEcuacionGeneral.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEcuacionGeneral.Location = new Point(186, 307);
            lblEcuacionGeneral.Name = "lblEcuacionGeneral";
            lblEcuacionGeneral.Size = new Size(0, 19);
            lblEcuacionGeneral.TabIndex = 18;
            // 
            // FrmCircunferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 341);
            Controls.Add(lblEcuacionGeneral);
            Controls.Add(lblEcuacionOrdinaria);
            Controls.Add(btnCalcular);
            Controls.Add(txtV4);
            Controls.Add(txtV3);
            Controls.Add(txtV2);
            Controls.Add(txtV1);
            Controls.Add(lblV4);
            Controls.Add(lblV3);
            Controls.Add(lblV2);
            Controls.Add(lblV1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Margin = new Padding(1);
            Name = "FrmCircunferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCircunferencia";
            Load += FrmCircunferencia_Load_1;
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(cmbTipo, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(lblV1, 0);
            Controls.SetChildIndex(lblV2, 0);
            Controls.SetChildIndex(lblV3, 0);
            Controls.SetChildIndex(lblV4, 0);
            Controls.SetChildIndex(txtV1, 0);
            Controls.SetChildIndex(txtV2, 0);
            Controls.SetChildIndex(txtV3, 0);
            Controls.SetChildIndex(txtV4, 0);
            Controls.SetChildIndex(btnCalcular, 0);
            Controls.SetChildIndex(lblEcuacionOrdinaria, 0);
            Controls.SetChildIndex(lblEcuacionGeneral, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private Label lblV1;
        private Label lblV2;
        private Label lblV3;
        private Label lblV4;
        private TextBox txtV1;
        private TextBox txtV2;
        private TextBox txtV3;
        private TextBox txtV4;
        private Button btnCalcular;
        private Label lblEcuacionOrdinaria;
        private Label lblEcuacionGeneral;
    }
}