using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part40_FolderBrowserDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFolder_Click(object sender, EventArgs e)
        {
            if (folder.ShowDialog() != DialogResult.Cancel)
            {
                lblFolder.Text = folder.SelectedPath;
            }
        }
    }
}
