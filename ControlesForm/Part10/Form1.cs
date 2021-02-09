using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // lista.Columns.Add();
            ListViewItem item1 = new ListViewItem("Filipe");
            item1.SubItems.Add("11 9856-3552");
            item1.SubItems.Add("filipe.chaves@mail.com");

            ListViewItem item2 = new ListViewItem("Cassila");
            item2.SubItems.Add("11 98565-0151");
            item2.SubItems.Add("Cassila@mail.com");

            ListViewItem item3 = new ListViewItem("Pedro");
            item3.SubItems.Add("11 96354-1155");
            item3.SubItems.Add("Pedro@mail.com");

            ListViewItem item4 = new ListViewItem("Joao");
            item4.SubItems.Add("11 90000-6632");
            item4.SubItems.Add("Pedro@mail.com");

            ListViewItem item5 = new ListViewItem(new string[] { "Nice", "13 5689-5645", "mail" });

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);
            lista.Items.Add(item5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.LabelEdit = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  lista.Items.Remove(lista.SelectedItems[0]);
            lista.Items.RemoveAt(lista.SelectedIndices[0]);
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lista.SelectedItems[0].Text 
               );
        }
    }
}
