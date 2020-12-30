using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            //int numero = 0;
            //int[]  numeros = new int[5];
            //numeros[0] = 10;
            //numeros[1] = 15;
            //numeros[2] = 20;
            //numeros[3] = 30;
            //numeros[4] = 35;
            ////string[] nomes = new string[3];
            ////nomes[0] = "Filipe ";
            ////nomes[1] = "Augusto ";
            ////nomes[2] = "Santos ";

            //string[] nomes = {"Filipe", "Augusto", "Santos" };
            //Console.WriteLine(nomes[0]);
            //Console.WriteLine(numeros[0]);
            #endregion

            //int[,] numeros = new int[2, 3];
            //numeros[0, 0] = 10;
            //numeros[0, 1] = 20;
            //numeros[0, 2] = 30;

            //numeros[1, 0] = 5;
            //numeros[1, 1] = 15;
            //numeros[1, 2] = 25;

            //for(int x = 0; x <= 1; x++)
            //{
            //    for(int y=0; y <= 2; y++)
            //    {
            //    Console.Write("["+x+","+y+ "] = "+numeros[x,y]+"; ");
            //    }
            //    Console.WriteLine("");
            //}

            string[,] nomes ={
                {"filipe","augusto","Chaves" },
                {"Cassila","nascimento","fonseca" }
            };

            
            Console.ReadLine();
        }
    }
}
