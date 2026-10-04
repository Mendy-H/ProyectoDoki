namespace ProyectoDoki
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            pictureBox1 = new PictureBox();
            btnAtras = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.MistyRose;
            btnAtras.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtras.Location = new Point(12, 463);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(211, 59);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnatras_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.PaleTurquoise;
            btnCerrar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(638, 463);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(211, 59);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(874, 551);
            Controls.Add(btnCerrar);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox1);
            Name = "FrmBase";
            Text = "FrmBase";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        protected Button btnAtras;
        protected Button btnCerrar;
    }
}