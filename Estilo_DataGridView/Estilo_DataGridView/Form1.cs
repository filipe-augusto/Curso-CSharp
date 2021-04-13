using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estilo_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
         new object[]
         {
                    "filipe Augusto Santos Chaves",
                31,
                "windows Developer",
                "Washington"
         });
            dataGridView1.Rows.Add(
            new object[]
            {
                                "Sean Gust",
                            29,
                            "IOS Front and Developer",
                            "São Paulo"
            });
            dataGridView1.Rows.Add(
                 new object[]
                 {
                    "Chaves Pierro",
                    25,
                    "  Developer ",
                    "São Paulo"
                 });
            dataGridView1.Rows.Add(
               new object[]
               {
                    "Pedro Pierro",
                    25,
                    "  Doctor of dates ",
                    "São Paulo"
               });
            dataGridView1.Rows.Add(
            new object[]
            {
                    "Ozorio Stone",
                    25,
                    "  Driver ",
                    "São Diego"
            });


        }
    }
}
