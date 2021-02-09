using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part20
{
    public partial class btnGo : Form
    {
        public btnGo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                browser.Navigate("https://" + txtEndereco.Text);
            }catch (Exception)
            {
                MessageBox.Show($"Pagina {txtEndereco.Text} nao encontrada");
            }

         
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }
    }
}
