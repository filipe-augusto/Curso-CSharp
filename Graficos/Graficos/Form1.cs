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
        int contadorX = 0;

        private void btnLimparGraficos_Click(object sender, EventArgs e)
        {
            valores.Clear();
            grafico.Series[0].Points.Clear();
            dataGridView1.Rows.Clear();
            contadorX = 0;
            txtValorX.Text = "";
            txtValorY.Text = "";
            txtValorX.Focus();
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
            var items = from valor in valores orderby valor.Key ascending select valor;



            foreach (var item in items)
            {
                dataGridView1.Rows.Add(item.Key, item.Value);
                grafico.Series[0].Points.AddXY(item.Key, item.Value);
            }
            grafico.Update();
            txtValorX.Text = "";
            txtValorY.Text = "";
            txtValorX.Focus();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtValorX.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtValorY.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Series[0].ChartType = (SeriesChartType)tipoGrafico.SelectedItem;
        }

        private void palleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Palette = (ChartColorPalette)palleteCor.SelectedItem;
        }

        private void grafico3D_CheckedChanged(object sender, EventArgs e)
        {
            grafico.ChartAreas[0].Area3DStyle.Enable3D = grafico3D.Checked;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (grafico.Series[0].Points.Count() > 10)
            {
                grafico.Series[0].Points.RemoveAt(0);
                grafico.Update();
            }
            double y = (double)new Random((int)DateTime.Now.Ticks).Next(1000);
            grafico.Series[0].Points.AddXY(contadorX++, y);
            dataGridView1.Rows.Add(contadorX, y);
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
