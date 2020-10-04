using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        double Salb, SalLiq, nFilhos, SalFam, DescINSS, DescIRPF;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {


            if (double.TryParse(mskdtxtSalbrut.Text, out Salb) &&
             double.TryParse(mskdtxtboxFilhos.Text, out nFilhos) &&
             (rbdnF.Checked || rbdnM.Checked))
            {
                //calculo INSS
                if (Salb <= 800.47)
                {
                    DescINSS = (7.65 / 100) * Salb;
                    txtAliqin.Text = "7,65%";

                }
                else if (Salb <= 1050)
                {
                    DescINSS = (8.65 / 100) * Salb;
                    txtAliqin.Text = "8,65%";

                }
                else if (Salb <= 1400.77)
                {
                    DescINSS = (9 / 100) * Salb;
                    txtAliqin.Text = "9,00%";

                }
                else if (Salb <= 2801.56)
                {
                    DescINSS = (11 / 100) * Salb;
                    txtAliqin.Text = "11,00%";

                }
                else
                {
                    DescINSS = 308.17;
                    txtAliqin.Text = "Teto";
                }
                //irpf
                if (Salb <= 1257.12)
                {
                    txtAliqir.Text = "isento";
                    txtDescir.Text = "0";
                }
                else if (Salb <= 2512.08)
                {
                    txtAliqir.Text = "15,00%";
                    DescIRPF = (15 / 100) * Salb;
                }
                else
                {
                    txtAliqir.Text = "27,50%";
                    DescIRPF = (27.5 / 100) * Salb;
                }
                //salario familia
                if (Salb < 435.52)
                {
                    SalFam = 22.33 * nFilhos;
                }
                else if (Salb <= 654.61)
                {
                    SalFam = 15.74 * nFilhos;
                }
                else
                    SalFam = 0;
              
        }
            else
            {
                MessageBox.Show("Preenche tudo ai");
            }




            SalLiq = Salb + (SalFam) - (DescIRPF + DescINSS);
            
            txtDescir.Text = DescIRPF.ToString();
            txtSalf.Text = SalFam.ToString();
            txtSalliq.Text = SalLiq.ToString();
            txtDescin.Text = DescINSS.ToString();
        }
    }
}
