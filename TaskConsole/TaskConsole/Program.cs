using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task Part 1
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa);

            //Task.Run(Tarefa);
            //Task.Factory.StartNew(Tarefa);

            //Task.Run(() => {
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("tarefa anonima");
            //    }
            //});
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("tarefa anonima");
            //}
            #endregion
            #region Task Part 2
            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(()=>{                
            //        Console.WriteLine("Tarefa 1");
            //    }),
            //        Task.Factory.StartNew(()=>{
            //             Console.WriteLine("Tarefa 2");
            //        }),
            //            Task.Factory.StartNew(()=>{
            //                 Console.WriteLine("Tarefa 3");
            //            }),
            //                Task.Factory.StartNew(()=>{
            //                     Console.WriteLine("Tarefa 4");
            //                })
            //};
            //  Task.WaitAll(tasks);// executa a task primeiro e o resto espera
            //Task t1 = Task.Run(() => { Console.WriteLine("Comando #1"); });
            //Task t2 = Task.Run(() => { Console.WriteLine("Comando #2"); });
            //Task t3 = Task.Run(() => { Console.WriteLine("Comando #3"); });
            //Task.WaitAll(t1,t2,t3);//na ordem
            //Console.WriteLine("Principal");
            //Console.ReadKey();
            #endregion
            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(5));
            //Console.WriteLine(tarefa1.Result);
            //Console.ReadKey();  

            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
               // return new Random().Next(10);//0 a 9
                return 5;
            });

            Task<int> tarefa2 = tarefa1.ContinueWith((num)=> {
                return num.Result * 2;
            });

            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return "Valor final " + num.Result;
            });

            Console.WriteLine(tarefa3.Result);
            Console.ReadKey();
        }

        static int Dobro(int num)
        {
            return num * 2;
        }
        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Taregfa do task");
            }
        }
    }
}
