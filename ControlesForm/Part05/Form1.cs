using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(check1.Text + " "+ check1.Checked);
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(check2.Text + " " + check2.Checked);
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(check3.Text + " " + check3.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checados = "";
            if (check1.Checked)
            {
                checados += check1.Text + " - ";
            }
            if (check2.Checked)
            {
                checados += check2.Text + " - ";
            }
            if (check3.Checked)
            {
                checados += check3.Text ;
            }

            MessageBox.Show(checados);
        }
    }
}
