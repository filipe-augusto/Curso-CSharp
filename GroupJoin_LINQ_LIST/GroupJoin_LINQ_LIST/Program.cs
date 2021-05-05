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
            IList<NotaFiscal> notas = new List<NotaFiscal>()
            {
                new NotaFiscal(){CodigoNF = 202151, NomeEmpresa = "Mxlog", ValorTotal = 2100.00  },
                new NotaFiscal(){CodigoNF = 202152, NomeEmpresa = "RCT", ValorTotal = 1600.00 },
                new NotaFiscal(){CodigoNF = 202153, NomeEmpresa = "Atento", ValorTotal = 1400.00 },
                new NotaFiscal(){CodigoNF = 202154, NomeEmpresa = "Telperformance", ValorTotal = 1500.00 },
            };

            IList<Item> itens = new List<Item>()
            {
                new Item(){ CodigoNF = 202151, DescritionItem = "serviço de motoboy", Valor = 100},
                new Item(){ CodigoNF = 202151, DescritionItem = "serviço de faxina", Valor = 150},
                new Item(){ CodigoNF = 202152, DescritionItem = "serviço de motoboy", Valor = 100},
                   new Item(){ CodigoNF = 202153, DescritionItem = "serviço de motoboy", Valor = 100},
                      new Item(){ CodigoNF = 202153, DescritionItem = "serviço de faxina", Valor = 150},
                       new Item(){ CodigoNF = 202153, DescritionItem = "serviço de segurança", Valor = 140},
                        new Item(){ CodigoNF = 202154, DescritionItem = "serviço de motoboy", Valor = 100},
            };
            var notasGroupItens = notas.GroupJoin(itens,  //inner sequence
                                nf => nf.CodigoNF, //outerKeySelector 
                                i => i.CodigoNF,     //innerKeySelector
                                (_notaFiscal, _itens) => new // resultSelector 
                                {
                                    ITEMS = _itens,
                                    NOTA = _notaFiscal
                                });

            foreach (var nota in notasGroupItens)
            {
                Console.WriteLine($"{nota.NOTA.CodigoNF } - {nota.NOTA.NomeEmpresa} - {nota.NOTA.ValorTotal}");
                foreach (var item in nota.ITEMS)
                {
                    Console.WriteLine($"    {item.CodigoNF} - {item.DescritionItem} - {item.Valor}");
                }
            }
            Console.ReadKey();

        }
    }
}
