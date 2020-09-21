namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Raio = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Raio
            // 
            this.Raio.AutoSize = true;
            this.Raio.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raio.Location = new System.Drawing.Point(109, 45);
            this.Raio.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Raio.MaximumSize = new System.Drawing.Size(333, 300);
            this.Raio.Name = "Raio";
            this.Raio.Size = new System.Drawing.Size(123, 55);
            this.Raio.TabIndex = 0;
            this.Raio.Text = "Raio";
            this.Raio.Click += new System.EventHandler(this.label1_Click);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume.Location = new System.Drawing.Point(109, 197);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(187, 55);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(109, 113);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(149, 55);
            this.altura.TabIndex = 4;
            this.altura.Text = "Altura";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(203, 283);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(168, 46);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(438, 283);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(171, 46);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(302, 53);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(301, 47);
            this.textBoxR.TabIndex = 7;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(302, 122);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(301, 47);
            this.textBoxA.TabIndex = 8;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(302, 205);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(301, 47);
            this.textBoxV.TabIndex = 9;
            this.textBoxV.TextChanged += new System.EventHandler(this.textBoxV_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._1200830;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._1200830;
            this.pictureBox1.Location = new System.Drawing.Point(710, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.Raio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Calcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Raio;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

