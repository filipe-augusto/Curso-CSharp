using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblResultado.Text = $"Dia: {dateTimePicker.Value.DayOfWeek} \n" +
                $"Dia: {dateTimePicker.Value.Day} \n" +
                $"Mes: {dateTimePicker.Value.Month} \n" +
                   $"Ano: {dateTimePicker.Value.Year} \n" +
                      $"Hora: {dateTimePicker.Value.Hour} \n" +
                         $"Minutos: {dateTimePicker.Value.Minute} \n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime atual = DateTime.Now;
            dateTimePicker.Value = atual;
        }
    }
}
