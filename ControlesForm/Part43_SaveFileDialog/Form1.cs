using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part43_SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            save.Filter = "text| *.txt| documento |*.doc|portavel|*.pdf";

            if (save.ShowDialog()!= DialogResult.Cancel)
            {
                label1.Text = save.FileName;
            }
        }
    }
}
