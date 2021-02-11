using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part42_FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFont_Click(object sender, EventArgs e)
        {

            if (font.ShowDialog() != DialogResult.Cancel)
            {
                lblFont.Font = font.Font;
                lblFont.ForeColor = font.Color;
            }
            
        }

        private void font_Apply(object sender, EventArgs e)
        {
          
                lblFont.Font = font.Font;
                lblFont.ForeColor = font.Color;
            

        }
    }
}
