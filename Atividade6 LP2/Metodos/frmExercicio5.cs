﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void número_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int valor1, valor2;

            valor1 = Convert.ToInt32(txtNumero1.Text);
            valor2 = Convert.ToInt32(txtNumero2.Text);

            Random numAleatorio = new Random();
            int resutado = numAleatorio.Next(valor1, valor2 + 1);
            MessageBox.Show("O número sortedado é:" + resutado);



        }
    }
}
