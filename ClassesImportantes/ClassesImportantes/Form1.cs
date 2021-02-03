using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagemBox_Click(object sender, EventArgs e)
        {
            #region MESSAGEM BOX
            // MessageBox.Show("Mensagem", "Titulo da mensage");
            //MessageBox.Show("Mensagem", "Titulo da mensage",MessageBoxButtons.YesNoCancel);
            // MessageBox.Show("Mensagem", "Titulo da mensage", MessageBoxButtons.AbortRetryIgnore);
            //MessageBox.Show("Mensagem", "Titulo da mensage", MessageBoxButtons.AbortRetryIgnore);

            //DialogResult res = MessageBox.Show("Mensagem", "Titulo da mensage", MessageBoxButtons.OKCancel);
            //if(res == DialogResult.OK)
            //{
            //    lblResultado.Text = "clicou em ok";
            //}else if (res == DialogResult.Cancel)
            //{
            //    lblResultado.Text = "clicou em cancelar";
            //}

            //MessageBox.Show("Mensagem", "Tiulo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //MessageBox.Show("Mensagem", "Tiulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //MessageBox.Show("Mensagem", "Tiulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //MessageBox.Show("Mensagem", "Tiulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            MessageBox.Show("Mensagem", "Tiulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            // Random r = new Random();
            Random r = new Random(DateTime.Now.Millisecond);
            // r.Next(100);//até 100
            //  r.Next(10,100);//de 11 até 99
            int valor = r.Next(100);
            double valor2 = r.NextDouble() * 100;
            lblResultado.Text = "Numero 1 : " + valor + "Numero 2 : " + valor2;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {

            //lblResultado.Text = TimeSpan.FromMinutes(90).ToString();
            //lblResultado.Text = TimeSpan.FromDays(90).ToString();
            //lblResultado.Text = TimeSpan.FromTicks(10000000).ToString();
            //  lblResultado.Text = TimeSpan.TicksPerMinute.ToString();
            TimeSpan inicio = new TimeSpan(19, 00, 0);
            TimeSpan fim = new TimeSpan(20, 47, 0);
            TimeSpan intervalo = fim - inicio;
            // TimeSpan intervalo = fim + inicio;
            //  lblResultado.Text = intervalo.ToString();
            //  lblResultado.Text = intervalo.Hours.ToString();
            inicio.Add(fim);

            // lblResultado.Text = intervalo.TotalHours.ToString();
            lblResultado.Text = intervalo.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();//tempo atual
            //lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2021, 02).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2021).ToString();
            //lblResultado.Text = DateTime.Now.ToLongTimeString();
            //lblResultado.Text = DateTime.Now.ToShortTimeString();
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            // lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm"); = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            DateTime data = new DateTime(1993, 07, 04, 00, 00, 30);
            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            // lblResultado.Text = data.AddYears(28).ToString();
            lblResultado.Text = data.Add(tempo).ToString();
            lblResultado.Text = data.DayOfWeek.ToString();
           // lblResultado.Text = data.Add(tempo).ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            Color cor1 = Color.FromArgb(100, amarelo);
            Color cor2 = Color.FromArgb(100, 255,255,255);
            Color cor3 = Color.FromKnownColor(KnownColor.Control);
            lblResultado.BackColor = vermelho;
          //  lblResultado.ForeColor = amarelo;
            lblResultado.ForeColor = cor2;

            //pegar cor
            Color cor4 = lblResultado.BackColor;
            btnColor.BackColor = cor4;
        }

        private void butFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Arial", 36, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);
            lblResultado.Text = "bem vindo c#, trbalhando com fontes";
            lblResultado.Font = letra;
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            //string meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string meusDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string cacheInternet = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            //lblResultado.Text = cacheInternet + Environment.NewLine + meusDesktop;

            //string varAmb = Environment.GetEnvironmentVariable("Path");
            //lblResultado.Text = varAmb;

            string user = Environment.UserName;
            string dominio = Environment.UserDomainName;
            int  cpu = Environment.ProcessorCount;
            lblResultado.Text = user +"\n" +dominio +" CPU:" + cpu;

            //string[] discos = Environment.GetLogicalDrives();
            //foreach(string item in discos)
            //{
            //    lblResultado.Text += "\n" + item;
            //}
        }
    }

}
