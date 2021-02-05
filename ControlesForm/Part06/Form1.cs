using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part06
{
    public partial class btnCheckQuantidade : Form
    {
        public btnCheckQuantidade()
        {
            InitializeComponent();
            checkList.Items.Add("Carro",true);
            checkList.Items.Add("Moto", false);
            checkList.Items.Add("Bike", false);
            checkList.Items.Add("Barco");
            checkList.Items.Add("Avião");
            int quantItemscheckList = checkList.Items.Count;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            checkList.Items.Clear();
        }

        private void btnAddGrupo_Click(object sender, EventArgs e)
        {
            checkList.Items.AddRange(new object[] { "Bike", "Mobilete", "Caminhão" });
        }

        private void btnContem_Click(object sender, EventArgs e)
        {
            bool res = checkList.Items.Contains(txtContem.Text);
            if (res)
            {
                MessageBox.Show("contém");
            }
            else
            {
                MessageBox.Show(" não contém");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object item = checkList.SelectedItem;
            checkList.Items.Remove(item);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkList.Items.Insert(1, txtAdd.Text);
        }

        private void btnQuantidadeChecados_Click(object sender, EventArgs e)
        {
            var items = checkList.CheckedItems;
            foreach(var item in items)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = checkList.SelectedItem.ToString();
        }
    }
}
