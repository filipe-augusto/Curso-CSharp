using Linq_Exercicio.Entitie;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Linq_Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Product> list = new List<Product>();
        private void btnBuscar_Click(object sender, EventArgs e)
        { 
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblcaminho.Text = openFileDialog1.FileName;//so pode ser o arquivo in.txt na pasta do projeto
            }
            using (StreamReader sr =  File.OpenText(lblcaminho.Text))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            lblMedia.Text = "Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture);
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach ( string  name in names)
            {
            txtlistas.Items.Add(name);
            }


        }
    }
}
