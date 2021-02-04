using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControl
{
    public partial class FormControl : Form
    {
        Label label1;
        Button btn1;
        public FormControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            label1 = new Label();
            label1.Location = new Point(200, 150);//posicao label
            label1.AutoSize = false;
            label1.Size = new Size(200,200);
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            label1.Text = "Minha label";
            
            btn1 = new Button();
            btn1.Location = new Point(400, 50);//posicao label
            btn1.Size = new Size(200, 60);
            btn1.Text = "Botão codigo";
            btn1.Font = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Click += btn1_Click;
            btn1.MouseEnter += btn1_MouseEnter;
            this.Controls.Add(label1);
            this.Controls.Add(btn1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            label1.Text = "Clicou no botão"; 
        }
        private void btn1_MouseEnter(object sender, EventArgs e)
        {

            label1.Text = "passou o mouse";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
