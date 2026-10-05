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
            label1.Location = new Point(206, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 27);
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
            label2.Location = new Point(277, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "(Prácticas)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 2;
            label3.Text = "Elige una opción";
            // 
            // cmbOpciones
            // 
            cmbOpciones.BackColor = SystemColors.Control;
            cmbOpciones.FormattingEnabled = true;
            cmbOpciones.Items.AddRange(new object[] { "Ecuación General", "Recta", "Circunferencia", "Elipse", "Parábola", "Hipérbola" });
            cmbOpciones.Location = new Point(93, 132);
            cmbOpciones.Margin = new Padding(2, 2, 2, 2);
            cmbOpciones.Name = "cmbOpciones";
            cmbOpciones.Size = new Size(438, 23);
            cmbOpciones.TabIndex = 3;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.LightSteelBlue;
            btnAbrir.CausesValidation = false;
            btnAbrir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(241, 238);
            btnAbrir.Margin = new Padding(2, 2, 2, 2);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(139, 28);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnAcerca
            // 
            btnAcerca.BackColor = Color.LightSteelBlue;
            btnAcerca.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAcerca.Location = new Point(59, 292);
            btnAcerca.Margin = new Padding(2, 2, 2, 2);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(139, 28);
            btnAcerca.TabIndex = 5;
            btnAcerca.Text = "Acerca de";
            btnAcerca.UseVisualStyleBackColor = false;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightSteelBlue;
            btnSalir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(440, 292);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 28);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 7);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(615, 350);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnAcerca);
            Controls.Add(btnAbrir);
            Controls.Add(cmbOpciones);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
