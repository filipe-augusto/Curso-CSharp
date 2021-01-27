using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee.Entities;

namespace Employee
{
    public partial class Form1 : Form
    {

        List<OutsourcedEmployee> employees;
        public Form1()
        {
            InitializeComponent();
            employees = new List<OutsourcedEmployee>();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            OutsourcedEmployee funcionario = new OutsourcedEmployee();
            try
            {
            double valueAdditional = checkOutSource.Checked ? double.Parse(textAdditionalCharge.Text) : 0;
                int index = -1;
                foreach (OutsourcedEmployee emp in employees)//check the list if contains any an employee in list
                {
                    if (emp.Name == textName.Text)
                    {
                        index = employees.IndexOf(emp);//get the number of employee in  list 
                    }
                }

                if (textName.Text == "")
                {
                    MessageBox.Show("Enter the field name");
                    textName.Focus();
                    return;
                }

                if (textHours.Text == "")
                {
                    MessageBox.Show("Enter the field Hours");
                    textName.Focus();
                    return;
                }
                if (textValuePerEployee.Text == "")
                {
                    MessageBox.Show("Enter the field ValuePerEployee");
                    textName.Focus();
                    return;
                }

                funcionario.Name = textName.Text;
                funcionario.Hours = Int32.Parse(textHours.Text);
                funcionario.ValuePerHour = double.Parse(textValuePerEployee.Text);
                funcionario.AdditionalCharge = valueAdditional;

                if (index < 0)
                {
                    employees.Add(funcionario); //get new employee and put in the list
                }
                else
                {
                    employees[index] = funcionario; //
                }

                ListToTable();
                limpar();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void ListToTable()
        {
            listTable.Items.Clear();
            foreach (OutsourcedEmployee e in employees)
            {
                listTable.Items.Add($"{e.Name} - R${e.Payment()}");
                // $" |    {e.Hours} |    {e.ValuePerHour} |    {e.AdditionalCharge} |    {e.Payment()}. ");
            }
        }


        private void limpar()
        {
            textName.Text = "";
            textValuePerEployee.Text = "";
            textAdditionalCharge.Text = "";
            checkOutSource.Checked = false;
            textHours.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panelOutSourcedEmployee.Visible = false;
        }

        private void checkValuePerHour_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOutSource.Checked)
            {
                panelOutSourcedEmployee.Visible = true;
            }
            else
            {
                panelOutSourcedEmployee.Visible = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpar();
            textName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int indice = listTable.SelectedIndex;
                employees.RemoveAt(indice);
                ListToTable();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione um nome na lista");
            }

        }

        private void listTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = listTable.SelectedIndex;
            OutsourcedEmployee employeeOfList = employees[indice];
            textName.Text = employeeOfList.Name;
            textHours.Text = employeeOfList.Hours.ToString();
            textValuePerEployee.Text = employeeOfList.ValuePerHour.ToString();

            if (employeeOfList.ValuePerHour > 0)
            {
                checkOutSource.Checked = true;
                textAdditionalCharge.Text = employeeOfList.AdditionalCharge.ToString();
            }
            else
            {
                textAdditionalCharge.Text = employeeOfList.ValuePerHour.ToString();
            }

        }

    
    }
}
