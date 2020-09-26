using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesoid
{
    public partial class Form1 : Form
    {
        double Alt, PesoAt, PesoIdF, PesoIdm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Altura_Click(object sender, EventArgs e)
        {

        }

        private void rdbnMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtAlt.Clear();
            txtPeso.Clear();
            txtPesoid.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbtnFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out PesoAt) &&
                double.TryParse(txtAlt.Text, out Alt))
            {
                
                PesoIdF = (62.1 * Alt) - 44.7;
                PesoIdm = (72.7 * Alt) - 58;
                PesoIdm = Math.Round(PesoIdm, 1);
                PesoIdF = Math.Round(PesoIdF, 1);
                if (rbtnFem.Checked)
                {                    
                    txtPesoid.Text = PesoIdF.ToString();
                    if ( PesoAt < PesoIdF)
                        {
                        MessageBox.Show("Ta magrinha, pode comer mais");
                        }
                    else
                        if (PesoAt > PesoIdF)
                    {
                        MessageBox.Show("Ta um pouco acima, fica esperta com os doce ai");
                    }
                    else
                        MessageBox.Show("Opa, ta certinho ai, continue assim");
                 
                }
                else 
                   if (rdbnMasc.Checked)
                {
                    txtPesoid.Text = PesoIdm.ToString();
                        if (PesoAt < PesoIdm)
                        {
                            MessageBox.Show("Ta magrinho, pode comer mais");
                        }
                    else
                        if (PesoAt > PesoIdm)
                    {
                            MessageBox.Show("Ta um pouco acima, fica esperto com os doce ai");
                        }
                    else
                            MessageBox.Show("Opa, ta certinho ai, continue assim");

                }
                else
                    MessageBox.Show("Ta faltando por o genero");
            }
            else
                MessageBox.Show("Seu peso e sua altura deveriam ser apenas numeros");
          
        }
             
        

        }
    }

