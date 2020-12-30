using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição Switch
            //    int escolha = 1;
            //    switch (escolha)
            //    {
            //        case 1:
            //            Console.WriteLine("Opção 1");
            //            break;
            //        case 2:
            //            Console.WriteLine("Opção 1");
            //            break;
            //        case 3:
            //            Console.WriteLine("Opção 1");
            //            break;
            //        default:

            //            break;
            //    }
            #endregion

            Inicio:
            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    goto Inicio;
                    
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }
            Console.WriteLine("Valor final " + valor);
            Console.ReadKey();
            
        }
        }
    }
