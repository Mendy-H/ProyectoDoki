namespace ProyectoDoki
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbOpciones = new ComboBox();
            btnAbrir = new Button();
            btnAcerca = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 73);
            label1.Name = "label1";
            label1.Size = new Size(340, 39);
            label1.TabIndex = 0;
            label1.Text = "Geometría Analítica";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(396, 112);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 1;
            label2.Text = "(Prácticas)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 173);
            label3.Name = "label3";
            label3.Size = new Size(198, 35);
            label3.TabIndex = 2;
            label3.Text = "Elige una opción";
            // 
            // cmbOpciones
            // 
            cmbOpciones.BackColor = SystemColors.Control;
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Items.AddRange(new object[] { "Ecuación General", "Recta", "Circunferencia", "Elipse", "Parábola", "Hipérbola" });
            cmbOpciones.Location = new Point(133, 220);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(624, 33);
            cmbOpciones.TabIndex = 3;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.LightSteelBlue;
            btnAbrir.CausesValidation = false;
            btnAbrir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(344, 396);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(199, 46);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnAcerca
            // 
            btnAcerca.BackColor = Color.LightSteelBlue;
            btnAcerca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAcerca.Location = new Point(84, 486);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(199, 46);
            btnAcerca.TabIndex = 5;
            btnAcerca.Text = "Acerca de";
            btnAcerca.UseVisualStyleBackColor = false;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightSteelBlue;
            btnSalir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(629, 486);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(199, 46);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(879, 583);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnAcerca);
            Controls.Add(btnAbrir);
            Controls.Add(cmbOpciones);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbOpciones;
        private Button btnAbrir;
        private Button btnAcerca;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
