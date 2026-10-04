namespace ProyectoDoki
{
    partial class FrmEcuGral
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtA = new TextBox();
            txtC = new TextBox();
            txtE = new TextBox();
            txtB = new TextBox();
            txtD = new TextBox();
            txtF = new TextBox();
            btnIdentifica = new Button();
            lblResultado = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(16, 482);
            btnAtras.Margin = new Padding(4, 3, 4, 3);
            btnAtras.Size = new Size(274, 61);
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(829, 482);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Size = new Size(274, 61);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Location = new Point(168, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(609, 26);
            label1.TabIndex = 3;
            label1.Text = "Ingresa los coeficientes de Ax² + Bxy + Cy² + Dx + Ey + F = 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Khaki;
            label2.Location = new Point(168, 186);
            label2.Name = "label2";
            label2.Size = new Size(39, 26);
            label2.TabIndex = 4;
            label2.Text = "A=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Khaki;
            label3.Location = new Point(455, 186);
            label3.Name = "label3";
            label3.Size = new Size(39, 26);
            label3.TabIndex = 5;
            label3.Text = "B=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Khaki;
            label4.Location = new Point(168, 267);
            label4.Name = "label4";
            label4.Size = new Size(38, 26);
            label4.TabIndex = 6;
            label4.Text = "C=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Khaki;
            label5.Location = new Point(455, 267);
            label5.Name = "label5";
            label5.Size = new Size(41, 26);
            label5.TabIndex = 7;
            label5.Text = "D=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Khaki;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(168, 352);
            label6.Name = "label6";
            label6.Size = new Size(40, 28);
            label6.TabIndex = 8;
            label6.Text = "E=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Khaki;
            label7.Location = new Point(455, 352);
            label7.Name = "label7";
            label7.Size = new Size(37, 26);
            label7.TabIndex = 9;
            label7.Text = "F=";
            // 
            // txtA
            // 
            txtA.Location = new Point(222, 179);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 33);
            txtA.TabIndex = 10;
            // 
            // txtC
            // 
            txtC.Location = new Point(222, 260);
            txtC.Name = "txtC";
            txtC.Size = new Size(150, 33);
            txtC.TabIndex = 11;
            txtC.TextChanged += txtC_TextChanged;
            // 
            // txtE
            // 
            txtE.Location = new Point(222, 349);
            txtE.Name = "txtE";
            txtE.Size = new Size(150, 33);
            txtE.TabIndex = 12;
            // 
            // txtB
            // 
            txtB.Location = new Point(512, 179);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 33);
            txtB.TabIndex = 13;
            // 
            // txtD
            // 
            txtD.Location = new Point(512, 260);
            txtD.Name = "txtD";
            txtD.Size = new Size(150, 33);
            txtD.TabIndex = 14;
            // 
            // txtF
            // 
            txtF.Location = new Point(512, 349);
            txtF.Name = "txtF";
            txtF.Size = new Size(150, 33);
            txtF.TabIndex = 15;
            // 
            // btnIdentifica
            // 
            btnIdentifica.BackColor = Color.Thistle;
            btnIdentifica.Location = new Point(331, 408);
            btnIdentifica.Name = "btnIdentifica";
            btnIdentifica.Size = new Size(184, 48);
            btnIdentifica.TabIndex = 16;
            btnIdentifica.Text = "Identifica";
            btnIdentifica.UseVisualStyleBackColor = false;
            btnIdentifica.Click += btnIdentifica_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.LemonChiffon;
            lblResultado.Location = new Point(384, 482);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 26);
            lblResultado.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.NavajoWhite;
            label8.Location = new Point(331, 31);
            label8.Name = "label8";
            label8.Size = new Size(218, 26);
            label8.TabIndex = 18;
            label8.Text = "ECUACIÓN GENERAL";
            // 
            // FrmEcuGral
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 591);
            Controls.Add(label8);
            Controls.Add(lblResultado);
            Controls.Add(btnIdentifica);
            Controls.Add(txtF);
            Controls.Add(txtD);
            Controls.Add(txtB);
            Controls.Add(txtE);
            Controls.Add(txtC);
            Controls.Add(txtA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmEcuGral";
            Text = "FrmEcuGral";
            Controls.SetChildIndex(btnAtras, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtA, 0);
            Controls.SetChildIndex(txtC, 0);
            Controls.SetChildIndex(txtE, 0);
            Controls.SetChildIndex(txtB, 0);
            Controls.SetChildIndex(txtD, 0);
            Controls.SetChildIndex(txtF, 0);
            Controls.SetChildIndex(btnIdentifica, 0);
            Controls.SetChildIndex(lblResultado, 0);
            Controls.SetChildIndex(label8, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtA;
        private TextBox txtC;
        private TextBox txtE;
        private TextBox txtB;
        private TextBox txtD;
        private TextBox txtF;
        private Button btnIdentifica;
        private Label lblResultado;
        private Label label8;
    }
}