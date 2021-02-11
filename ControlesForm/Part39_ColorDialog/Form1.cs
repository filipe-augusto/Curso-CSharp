using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part39_ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblColor.BackColor;
            btnCor.BackColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblColor.BackColor = colorDialog1.Color;

            }
         }
    }
}
