using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part27_ContextMenuStrip
{

    public partial class Form1 : Form
    {
        string txt;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //copiar
            txt = txt1.Text;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // recortar
            txt = txt1.Text;
            txt1.Text = "";
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt!= null && txt !="")
            {
                txt2.Text = txt;
            }
            

        }
    }
}
