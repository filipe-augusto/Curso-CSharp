﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Filipe";
            this.Size = new Size(650,350);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "clicando no botao";
            lblTitulo.Text = "Clicou no botão";

        }

        private void botao1_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.Text = "Eventou mouse enter acionado";
        }

        private void botao1_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.Text = "Eventou mouse leave acionado";

        }
    
    }
}
