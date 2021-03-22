using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            valores = new Dictionary<double, double>();
        }

        Dictionary<double, double> valores;


        private void btnLimparGraficos_Click(object sender, EventArgs e)
        {
           
        }

  

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorX.Text) || String.IsNullOrEmpty(txtValorX.Text)) 
            {
                MessageBox.Show("Os dois valores são obrigatorios");
                return;
            }
            if (valores.ContainsKey(double.Parse(txtValorX.Text)))
            {
                valores[double.Parse(txtValorX.Text)] = double.Parse(txtValorY.Text);
            }
            else
            {
                valores.Add(double.Parse(txtValorX.Text), double.Parse(txtValorY.Text));
            }

            dataGridView1.Rows.Clear();
            grafico.Series[0].Points.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void palleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grafico3D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValorX.Focus();
            for (int i = 0; i < 35; i++)
            {
                tipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)
            {
                palleteCor.Items.Add((ChartColorPalette)i);
            }
        }

        private void txtValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8
                && e.KeyChar != (char)13 && e.KeyChar != (char)44) || 
                (txtValorX.Text.Contains((char)44) && e.KeyChar == (char)44))//se nao for digito e tbm sem backspace. e se ja tiver virgula 
            {
                e.Handled = true;
            }
        }

        private void txtValorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8
                && e.KeyChar != (char)13 && e.KeyChar != (char)44) ||
                (txtValorY.Text.Contains((char)44) && e.KeyChar == (char)44))//se nao for digito e tbm sem backspace. e se ja tiver virgula 
            {
                e.Handled = true;
            }
        }
    }
}
