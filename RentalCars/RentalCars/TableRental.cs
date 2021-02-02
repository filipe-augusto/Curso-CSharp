using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string sourcePath = @"c:\temp\file1.txt";//@ serve para nao colocar o @
            string targetePath = @"Files\list.txt";

            try
            {
               int lines = listRental.Items.Count;
                using (StreamWriter sw = File.AppendText(targetePath))
                {
                    for (int i = 0; i < lines; i++)
                    {
                        sw.WriteLine("texto");
                    }
                        
                    
                }
            }
            catch (IOException eee )
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(eee.Message );
            }

        }

        public void listar(string paramRental)
        {    
                listRental.Items.Add($"1 - {paramRental}");                          
        }
    }

}