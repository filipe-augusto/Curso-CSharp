using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = monthCalendar1.TodayDate;
          //  MessageBox.Show(data.Day + "/" + data.Month + "/" + data.Year); 
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // MessageBox.Show(monthCalendar1.SelectionStart.ToString());
            // lblResultado.Text = monthCalendar1.SelectionStart.ToString();

            lblResultado.Text = monthCalendar1.SelectionStart.Day.ToString()+ "/" +
               monthCalendar1.SelectionStart.Month.ToString()+ "/" +
                monthCalendar1.SelectionStart.Year.ToString();
        }
    }
}
