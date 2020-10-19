namespace Metodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestaIguais = new System.Windows.Forms.Button();
            this.btnPrimeiroESegundo = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(182, 64);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(182, 95);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palavra1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Palavra2";
            // 
            // btnTestaIguais
            // 
            this.btnTestaIguais.Location = new System.Drawing.Point(74, 154);
            this.btnTestaIguais.Name = "btnTestaIguais";
            this.btnTestaIguais.Size = new System.Drawing.Size(114, 66);
            this.btnTestaIguais.TabIndex = 4;
            this.btnTestaIguais.Text = "Testar iguais";
            this.btnTestaIguais.UseVisualStyleBackColor = true;
            this.btnTestaIguais.Click += new System.EventHandler(this.btnTestaIguais_Click);
            // 
            // btnPrimeiroESegundo
            // 
            this.btnPrimeiroESegundo.Location = new System.Drawing.Point(241, 154);
            this.btnPrimeiroESegundo.Name = "btnPrimeiroESegundo";
            this.btnPrimeiroESegundo.Size = new System.Drawing.Size(120, 66);
            this.btnPrimeiroESegundo.TabIndex = 5;
            this.btnPrimeiroESegundo.Text = "Inserir primeiro no segundo";
            this.btnPrimeiroESegundo.UseVisualStyleBackColor = true;
            this.btnPrimeiroESegundo.Click += new System.EventHandler(this.btnPrimeiroESegundo_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(407, 154);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(109, 66);
            this.btnInserir2.TabIndex = 6;
            this.btnInserir2.Text = "inserir 2 Asteriscos";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 256);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnPrimeiroESegundo);
            this.Controls.Add(this.btnTestaIguais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestaIguais;
        private System.Windows.Forms.Button btnPrimeiroESegundo;
        private System.Windows.Forms.Button btnInserir2;
    }
}