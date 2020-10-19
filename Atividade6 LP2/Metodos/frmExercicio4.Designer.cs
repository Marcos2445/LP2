namespace Metodos
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContaNumero = new System.Windows.Forms.Button();
            this.btnPosição = new System.Windows.Forms.Button();
            this.btnContaLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(160, 111);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(453, 164);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnContaNumero
            // 
            this.btnContaNumero.Location = new System.Drawing.Point(103, 352);
            this.btnContaNumero.Name = "btnContaNumero";
            this.btnContaNumero.Size = new System.Drawing.Size(115, 64);
            this.btnContaNumero.TabIndex = 1;
            this.btnContaNumero.Text = "Contar Números";
            this.btnContaNumero.UseVisualStyleBackColor = true;
            this.btnContaNumero.Click += new System.EventHandler(this.btnContaNumero_Click);
            // 
            // btnPosição
            // 
            this.btnPosição.Location = new System.Drawing.Point(334, 352);
            this.btnPosição.Name = "btnPosição";
            this.btnPosição.Size = new System.Drawing.Size(115, 64);
            this.btnPosição.TabIndex = 2;
            this.btnPosição.Text = "posição primeiro braco";
            this.btnPosição.UseVisualStyleBackColor = true;
            this.btnPosição.Click += new System.EventHandler(this.btnPosição_Click);
            // 
            // btnContaLetra
            // 
            this.btnContaLetra.Location = new System.Drawing.Point(562, 352);
            this.btnContaLetra.Name = "btnContaLetra";
            this.btnContaLetra.Size = new System.Drawing.Size(115, 64);
            this.btnContaLetra.TabIndex = 3;
            this.btnContaLetra.Text = "Contar letras";
            this.btnContaLetra.UseVisualStyleBackColor = true;
            this.btnContaLetra.Click += new System.EventHandler(this.btnContaLetra_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContaLetra);
            this.Controls.Add(this.btnPosição);
            this.Controls.Add(this.btnContaNumero);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnContaNumero;
        private System.Windows.Forms.Button btnPosição;
        private System.Windows.Forms.Button btnContaLetra;
    }
}