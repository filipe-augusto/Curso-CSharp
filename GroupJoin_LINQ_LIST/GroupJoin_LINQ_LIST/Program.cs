using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupJoin_LINQ_LIST.Entity;

namespace GroupJoin_LINQ_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NotaFiscal> notas = new List<NotaFiscal>()
            {
                new NotaFiscal(){CodigoNF = 202151, NomeEmpresa = "Mxlog", ValorTotal = 2100.00  },
                new NotaFiscal(){CodigoNF = 202152, NomeEmpresa = "RCT", ValorTotal = 1600.00 },
                new NotaFiscal(){CodigoNF = 202153, NomeEmpresa = "Atento", ValorTotal = 1400.00 },
                new NotaFiscal(){CodigoNF = 202154, NomeEmpresa = "Telperformance", ValorTotal = 1500.00 },
                new NotaFiscal(){CodigoNF = 302151, NomeEmpresa = "AAA", ValorTotal = 2100.00  },
                new NotaFiscal(){CodigoNF = 302152, NomeEmpresa = "BBBB", ValorTotal = 1600.00 },
                new NotaFiscal(){CodigoNF = 302153, NomeEmpresa = "CCCC", ValorTotal = 1400.00 },
                new NotaFiscal(){CodigoNF = 302154, NomeEmpresa = "DDDD", ValorTotal = 1500.00 },
            };

            List<Item> itens = new List<Item>()
            {
                new Item(){ CodigoNF = 202151, DescritionItem = "serviço de motoboy", Valor = 100},
                new Item(){ CodigoNF = 202151, DescritionItem = "serviço de faxina", Valor = 150},
                new Item(){ CodigoNF = 202152, DescritionItem = "serviço de motoboy", Valor = 100},
                   new Item(){ CodigoNF = 202153, DescritionItem = "serviço de motoboy", Valor = 100},
                      new Item(){ CodigoNF = 202153, DescritionItem = "serviço de faxina", Valor = 150},
                       new Item(){ CodigoNF = 202153, DescritionItem = "serviço de segurança", Valor = 140},
                        new Item(){ CodigoNF = 202154, DescritionItem = "serviço de motoboy", Valor = 100},
                                  new Item(){ CodigoNF = 202151, DescritionItem = "serviço de motoboy", Valor = 100},
                new Item(){ CodigoNF = 302151, DescritionItem = "serviço de faxina", Valor = 150},
                new Item(){ CodigoNF = 302152, DescritionItem = "serviço de motoboy", Valor = 100},
                   new Item(){ CodigoNF = 302153, DescritionItem = "serviço de motoboy", Valor = 100},
                      new Item(){ CodigoNF = 302153, DescritionItem = "serviço de faxina", Valor = 150},
                       new Item(){ CodigoNF = 302153, DescritionItem = "serviço de segurança", Valor = 140},
                        new Item(){ CodigoNF = 302154, DescritionItem = "serviço de motoboy", Valor = 100},
            };
            var notasGroupItens = notas.GroupJoin(itens,  //inner sequence
                                nf => nf.CodigoNF, //outerKeySelector 
                                i => i.CodigoNF,     //innerKeySelector
                                (_notaFiscal, _itens) => new // resultSelector 
                                {
                                    ITEMS = _itens,
                                    NOTA = _notaFiscal
                                });

            try
            {
                int contador = 0;
                var ultimo = notas.Last();
                IEnumerable<Item> _tempItem = new List<Item>();
                List<NotaFiscal> _tempNotas = new List<NotaFiscal>();
                int contadorFile = 0;
                
                foreach (var NF_ITEM in notas)
                {
                    if (contador < 2)
                    {
                        _tempNotas.Add(NF_ITEM);
                        contador++;
                        if (NF_ITEM.Equals(ultimo))
                        {
                            contadorFile++;
                            _tempItem = from i in itens
                                        join nf in _tempNotas
                                        on i.CodigoNF equals nf.CodigoNF
                                        select i;
                            imprime(contadorFile, _tempNotas, _tempItem.ToList());
                            contadorFile++;
                            imprime(contadorFile, _tempNotas, _tempItem.ToList());    
                            contador = 0;
                            _tempNotas.Clear();
                            _tempItem.ToList().Clear();
                        }
                    }
                    else
                    {
                        contadorFile++;
                        _tempNotas.Add(NF_ITEM);

                        _tempItem = from i in itens
                                join nf in _tempNotas
                                on i.CodigoNF equals nf.CodigoNF select i;
                        imprime(contadorFile, _tempNotas, _tempItem.ToList());
                        contador = 0;
                        _tempNotas.Clear();
                    }
                }
            }

            catch (Exception e ) 
            {
                Console.WriteLine(e.Message );
            }
            Console.ReadKey();

        }

        //public static void imprime (int _count,List<Item> item, List<NotaFiscal> nota)
        public static void imprime(int _count, List<NotaFiscal> nota, List<Item> item)
        {
            Console.WriteLine("LOTE "+_count);
            foreach (var notas in nota)
            {
                Console.WriteLine($"    EMPRESA: " + notas.NomeEmpresa + " Nota: "+ notas.CodigoNF + $" - Valor: {notas.ValorTotal}");
                foreach (var itens in item)
                {
                    if (notas.CodigoNF == itens.CodigoNF)
                    {
                        Console.WriteLine("         Item: " + itens.CodigoNF + $" - Valor: {itens.Valor} - {itens}");
                    }
                }
           
            }

        }
    }
}
