using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part33_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Blue;
            label1.BackColor = Color.Red;
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            label1.Text = r.Next(100).ToString();    
        

            if (label1.ForeColor == Color.Red &&
                label1.BackColor== Color.Blue)
            {
                label1.ForeColor = Color.Blue;
                label1.BackColor = Color.Red;
            }
            else if (label1.ForeColor == Color.Blue
                && label1.BackColor == Color.Red)
            {
                label1.ForeColor = Color.Red;
                label1.BackColor = Color.Blue;
            }
            else
            {

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
