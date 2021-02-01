using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalCars.Entities;
using RentalCars.Services;


namespace RentalCars
{
    public partial class TableRental : Form
    {
        List<CarRental> aluguel;
        public TableRental()
        {
            InitializeComponent();
            aluguel = new List<CarRental>();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableRental_Load(object sender, EventArgs e)
        {



        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
          // listar();
        }

        public void listar(string paramRental)
        {    
                listRental.Items.Add($"1 - {paramRental}");                          
        }
    }

}