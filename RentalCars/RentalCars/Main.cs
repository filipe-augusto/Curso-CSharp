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
    public partial class Main : Form
    {
        List<CarRental> listaObjRental; 
        public Main()
        {
            InitializeComponent();
            listaObjRental  = new List<CarRental>();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string model = txtModel.Text;
                DateTime start = DateTime.Parse(dateP.Text + " " + timeP.Text);
                DateTime fisnish = DateTime.Parse(dateR.Text + " " + timeR.Text);
                double hour = double.Parse(txtPricePerHours.Text);
                double day = double.Parse(txtPricePerDays.Text);

                CarRental carRental = new CarRental(start, fisnish, new Vehicle(model));
                RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

                rentalService.ProcessInvoice(carRental);
                

                LabelResult.Text = carRental.Invoice.ToString();       
                listaObjRental.Add(new CarRental(start, fisnish, new Vehicle(model)));
            
            }
              
            catch (Exception )
            {
                MessageBox.Show("Ocorreu um erro, revise os campos");
            }
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
           // passar<CarRental>(listaObjRental);//passo uaa lista
                                       //tabela.listar();
                          
            TableRental tabela = new TableRental();


            for (int i = 0; i < listaObjRental.Count; i++)
            {
                tabela.listar(" Model car: " + listaObjRental[i].Vehicle.Model
                 + " Start: " + listaObjRental[i].Start
                    + " Finish: " + listaObjRental[i].Finish
                    + " Total Payment: " /*+ listaObjRental[i].Invoice.TotalPayment*/);
            }
               
            tabela.Show();
        }

        //public void passar<CarRental>(List<CarRental> paramRental)
        //{
     
           
        //}

    }
}//
