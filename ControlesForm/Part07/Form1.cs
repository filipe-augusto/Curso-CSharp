using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo.Items.Add("Carro");
            combo.Items.Add("Moto");
            combo.Items.Add("avião");
            combo.Items.Add("Bike");


            combo.Items.AddRange(new object[] { "cavalo", "elevador", "bike" });
       
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
             lblResultado.Text = combo.SelectedItem.ToString();
        }

        private void btnQuantidade_Click(object sender, EventArgs e)
        {
            lblResultado.Text = combo.Items.Count.ToString();
            lblResultado.ForeColor = Color.Blue;
            lblResultado.BackColor = Color.Black;
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            object item = combo.SelectedItem;
            int indice = combo.SelectedIndex;
            lblResultado.Text = item + " - " + indice;
            lblResultado.ForeColor = Color.White;
            lblResultado.BackColor = Color.DarkBlue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            combo.Items.Clear();
            lblResultado.Text = "limpou a lista";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
      
            combo.Items.Remove(combo.SelectedItem);
            lblResultado.Text = "Removido o selecionado o nome";
            lblResultado.ForeColor = Color.Red;
            lblResultado.BackColor = Color.DarkBlue;
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            combo.Items.RemoveAt(combo.SelectedIndex);
            lblResultado.Text = "Removido o selecionado usando index";
            lblResultado.ForeColor = Color.YellowGreen;
            lblResultado.BackColor = Color.DarkBlue;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            combo.Items.Insert(combo.Items.Count,txtCampo.Text);
            lblResultado.Text = "Adicinou o "+ txtCampo.Text;
            lblResultado.ForeColor = Color.YellowGreen;
            lblResultado.BackColor = Color.DarkBlue;
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            combo.Items.IndexOf(combo.SelectedIndex);
            lblResultado.Text = "usando index of. Item: "+
                combo.Items.IndexOf(combo.SelectedIndex);
            lblResultado.ForeColor = Color.Blue;
            lblResultado.BackColor = Color.DarkOliveGreen;
        }
    }
}
