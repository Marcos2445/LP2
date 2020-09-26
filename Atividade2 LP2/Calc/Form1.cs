using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double numero1, numero2;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtN1.Text, out numero1) &&
                double.TryParse(txtN2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtRes.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Mano, nem da pra fazer conta com isso ai");


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtRes.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtN1.Text, out numero1) &&
                double.TryParse(txtN2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtRes.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Mano, nem da pra fazer conta com isso ai");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtN1.Text, out numero1) &&
                double.TryParse(txtN2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtRes.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Mano, nem da pra fazer conta com isso ai");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtN1.Text, out numero1) &&
                double.TryParse(txtN2.Text, out numero2)&&
                numero2 != 0)
            {
                resultado = numero1 / numero2;
                txtRes.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Mano, nem da pra fazer conta com isso ai");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            Close();

        }
    }
}
