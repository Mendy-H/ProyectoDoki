namespace ProyectoDoki
{
    partial class FrmHiperbola
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
            label2 = new Label();
            label1 = new Label();
            lblEcuacionOrdinaria = new Label();
            btnCalcular = new Button();
            lblV4 = new Label();
            lblV3 = new Label();
            lblV2 = new Label();
            lblV1 = new Label();
            txtV4 = new TextBox();
            txtV3 = new TextBox();
            txtV2 = new TextBox();
            txtV1 = new TextBox();
            lblEcuacionGeneral = new Label();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Hipérbola Horizontal", "Hipérbola Vertical" });
            cmbTipo.Location = new Point(215, 68);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(162, 23);
            cmbTipo.TabIndex = 29;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Font = new Font("Sitka Banner", 10F);
            label2.Location = new Point(227, 45);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 28;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 27;
            label1.Text = "HIPERBOLA";
            // 
            // lblEcuacionOrdinaria
            // 
            lblEcuacionOrdinaria.AutoSize = true;
            lblEcuacionOrdinaria.BackColor = Color.DarkKhaki;
            lblEcuacionOrdinaria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEcuacionOrdinaria.Location = new Point(161, 261);
            lblEcuacionOrdinaria.Name = "lblEcuacionOrdinaria";
            lblEcuacionOrdinaria.Size = new Size(0, 19);
            lblEcuacionOrdinaria.TabIndex = 46;
            lblEcuacionOrdinaria.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Plum;
            btnCalcular.Font = new Font("Cambria", 11F, FontStyle.Bold);
            btnCalcular.Location = new Point(248, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 39);
            btnCalcular.TabIndex = 45;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblV4
            // 
            lblV4.AutoSize = true;
            lblV4.BackColor = Color.PaleGoldenrod;
            lblV4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV4.Location = new Point(260, 179);
            lblV4.Margin = new Padding(2, 0, 2, 0);
            lblV4.Name = "lblV4";
            lblV4.Size = new Size(0, 20);
            lblV4.TabIndex = 44;
            // 
            // lblV3
            // 
            lblV3.AutoSize = true;
            lblV3.BackColor = Color.PaleGoldenrod;
            lblV3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV3.ForeColor = Color.Black;
            lblV3.Location = new Point(28, 182);
            lblV3.Margin = new Padding(2, 0, 2, 0);
            lblV3.Name = "lblV3";
            lblV3.Size = new Size(0, 20);
            lblV3.TabIndex = 43;
            // 
            // lblV2
            // 
            lblV2.AutoSize = true;
            lblV2.BackColor = Color.PaleGoldenrod;
            lblV2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblV2.Location = new Point(260, 114);
            lblV2.Margin = new Padding(2, 0, 2, 0);
            lblV2.Name = "lblV2";
            lblV2.Size = new Size(0, 20);
            lblV2.TabIndex = 42;
            // 
            // lblV1
            // 
            lblV1.AutoSize = true;
            lblV1.BackColor = Color.PaleGoldenrod;
            lblV1.Font = new Font("Segoe UI", 11F);
            lblV1.Location = new Point(28, 114);
            lblV1.Name = "lblV1";
            lblV1.Size = new Size(0, 20);
            lblV1.TabIndex = 41;
            // 
            // txtV4
            // 
            txtV4.Location = new Point(358, 179);
            txtV4.Margin = new Padding(2);
            txtV4.Name = "txtV4";
            txtV4.Size = new Size(106, 23);
            txtV4.TabIndex = 40;
            txtV4.Visible = false;
            // 
            // txtV3
            // 
            txtV3.Location = new Point(139, 179);
            txtV3.Margin = new Padding(2);
            txtV3.Name = "txtV3";
            txtV3.Size = new Size(106, 23);
            txtV3.TabIndex = 39;
            // 
            // txtV2
            // 
            txtV2.Location = new Point(358, 111);
            txtV2.Margin = new Padding(2);
            txtV2.Name = "txtV2";
            txtV2.Size = new Size(106, 23);
            txtV2.TabIndex = 38;
            // 
            // txtV1
            // 
            txtV1.Location = new Point(139, 111);
            txtV1.Margin = new Padding(2);
            txtV1.Name = "txtV1";
            txtV1.Size = new Size(106, 23);
            txtV1.TabIndex = 37;
            // 
            // lblEcuacionGeneral
            // 
            lblEcuacionGeneral.AutoSize = true;
            lblEcuacionGeneral.BackColor = Color.DarkKhaki;
            lblEcuacionGeneral.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEcuacionGeneral.Location = new Point(161, 298);
            lblEcuacionGeneral.Name = "lblEcuacionGeneral";
            lblEcuacionGeneral.Size = new Size(0, 19);
            lblEcuacionGeneral.TabIndex = 47;
            // 
            // FrmHiperbola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 326);
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
            Name = "FrmHiperbola";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHiperbola";
            Load += FrmHiperbola_Load;
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

        private ComboBox cmbTipo;
        private Label label2;
        private Label label1;
        private Label lblEcuacionOrdinaria;
        private Button btnCalcular;
        private Label lblV4;
        private Label lblV3;
        private Label lblV2;
        private Label lblV1;
        private TextBox txtV4;
        private TextBox txtV3;
        private TextBox txtV2;
        private TextBox txtV1;
        private Label lblEcuacionGeneral;
    }
}