using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string digito;
        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
            digito = null;
                string str = txtMensagem.Text;

            byte[] arr = System.Text.Encoding.ASCII.GetBytes(str);


          //  string digito;
            for (int i = 0; i < arr.Length; i++)
            {
                digito += arr[i];
            }

            lblTela.Text = digito;           

        }
    }
}
