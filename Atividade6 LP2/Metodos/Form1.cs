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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou Copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou colar");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // testa se o formulário já está aberto
            Form fc = Application.OpenForms["frmExercicio2"];

            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio2 FrmExercicio2 = new frmExercicio2();
            FrmExercicio2.MdiParent = this;
            FrmExercicio2.WindowState = FormWindowState.Maximized;
            FrmExercicio2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // testa se o formulário já está aberto
            Form fc = Application.OpenForms["frmExercicio3"];

            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio3 FrmExercicio3 = new frmExercicio3();
            FrmExercicio3.MdiParent = this;
            FrmExercicio3.WindowState = FormWindowState.Maximized;
            FrmExercicio3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // testa se o formulário já está aberto
            Form fc = Application.OpenForms["frmExercicio4"];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio4 FrmExercicio4 = new frmExercicio4();
            FrmExercicio4.MdiParent = this;
            FrmExercicio4.WindowState = FormWindowState.Maximized;
            FrmExercicio4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // testa se o formulário já está aberto
            Form fc = Application.OpenForms["frmExercicio5"];
            if (fc != null)
            {
                fc.Close();
            }
            a FrmExercicio5 = new a();
            FrmExercicio5.MdiParent = this;
            FrmExercicio5.WindowState = FormWindowState.Maximized;
            FrmExercicio5.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
