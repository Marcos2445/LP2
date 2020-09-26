namespace Exercicio_triang
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
            this.txtboxA = new System.Windows.Forms.TextBox();
            this.txtboxB = new System.Windows.Forms.TextBox();
            this.txtboxC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnFec = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxA
            // 
            this.txtboxA.Location = new System.Drawing.Point(80, 50);
            this.txtboxA.Name = "txtboxA";
            this.txtboxA.Size = new System.Drawing.Size(60, 20);
            this.txtboxA.TabIndex = 0;
            // 
            // txtboxB
            // 
            this.txtboxB.Location = new System.Drawing.Point(80, 96);
            this.txtboxB.Name = "txtboxB";
            this.txtboxB.Size = new System.Drawing.Size(60, 20);
            this.txtboxB.TabIndex = 1;
            // 
            // txtboxC
            // 
            this.txtboxC.Location = new System.Drawing.Point(80, 140);
            this.txtboxC.Name = "txtboxC";
            this.txtboxC.Size = new System.Drawing.Size(60, 20);
            this.txtboxC.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(21, 53);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(41, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Lado A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lado B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lado C";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(41, 202);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(153, 202);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 7;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnFec
            // 
            this.btnFec.Location = new System.Drawing.Point(274, 202);
            this.btnFec.Name = "btnFec";
            this.btnFec.Size = new System.Drawing.Size(75, 23);
            this.btnFec.TabIndex = 8;
            this.btnFec.Text = "Fechar";
            this.btnFec.UseVisualStyleBackColor = true;
            this.btnFec.Click += new System.EventHandler(this.btnFec_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Exercicio_triang.Properties.Resources._7d1eaa58d091432e44ff2d73dc0f8056_silhueta_de___pice_tri__ngulo_is__sceles_by_vexels;
            this.pictureBox3.Location = new System.Drawing.Point(307, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Exercicio_triang.Properties.Resources.triangulo_equilatero_8;
            this.pictureBox2.Location = new System.Drawing.Point(307, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercicio_triang.Properties.Resources.escaleno;
            this.pictureBox1.Location = new System.Drawing.Point(307, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 237);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFec);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtboxC);
            this.Controls.Add(this.txtboxB);
            this.Controls.Add(this.txtboxA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxA;
        private System.Windows.Forms.TextBox txtboxB;
        private System.Windows.Forms.TextBox txtboxC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnFec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

