using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_triang
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtboxA.Clear();
            txtboxB.Clear();
            txtboxC.Clear();
        }

        private void btnFec_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //verificação
            if (double.TryParse(txtboxA.Text, out ladoA) &&
               double.TryParse(txtboxB.Text, out ladoB) &&
                double.TryParse(txtboxC.Text, out ladoC))
            {
                if (Math.Sqrt((ladoB - ladoC) * (ladoB - ladoC)) < ladoA &&
                    ladoA < ladoB + ladoC &&
                    (Math.Sqrt((ladoA - ladoC) * (ladoA - ladoC)) < ladoB &&
                    ladoB < ladoA + ladoC &&
                    (Math.Sqrt((ladoA - ladoB) * (ladoA - ladoB)) < ladoC &&
                    ladoC < ladoA + ladoB)))
                //equilatero
                {
                    if ((ladoA == ladoB) && (ladoC == ladoB))
                    { MessageBox.Show("Equilatero, todos lados iguais"); }
                    else
                    //escaleno
                        if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoC != ladoA))
                    { MessageBox.Show("Escaleno, todos lados diferentes"); }
                    //isósceles
                    else
                        MessageBox.Show("isósceles, dois lados iguais");
                }
                else
                    MessageBox.Show("Esses valores não formam um triangulo");
            }
            else
                MessageBox.Show("Os valores precisam ser numeros");
        }
    }
}
