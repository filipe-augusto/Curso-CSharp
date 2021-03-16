using InterfaceCompareble.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceCompareble
{
    class Program 
    {
        static void Main(string[] args) {

            string path = @"c:/temp/in.txt";
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //ordena
                    foreach (Employee  emp in list) //ler o arquivo
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);    
            }

        }
    }
}
