﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Location = new Point(100, 50);//posicao label
            label1.AutoSize = false;
            label1.Size = new Size(500,200);
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Arial", 28,FontStyle.Bold, GraphicsUnit.Point);
            label1.Text = "Minha label";
        }
    }
}
