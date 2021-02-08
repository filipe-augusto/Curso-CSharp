using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        private  delegate void AtualizarControle(Control controle, string propriedade, object valor);
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnPrincipal_Click(object sender, EventArgs e) {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        private void Tarefa()
        {
            while (true)
            {
              //  DefinirValoPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString());
                DefinirValoPropriedade(lblResultado, "BackColor", Color.Red);
                DefinirValoPropriedade(lblResultado, "BackColor", Color.Orange);
                DefinirValoPropriedade(lblResultado, "BackColor", Color.Green);
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.Second.ToString()));
            }
        }
        private void DefinirValoPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValoPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (var p in props)
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }
    }
}
