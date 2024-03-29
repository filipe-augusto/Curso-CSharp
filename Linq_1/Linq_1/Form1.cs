﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_1
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;
        public Form1()
        {
            InitializeComponent();

            #region Lista de Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Danny");
            lista_nomes.Add("Arthur");
            lista_nomes.Add("Danielle");
            lista_nomes.Add("Thuxs");
            lista_nomes.Add("Logan");
            lista_nomes.Add("Artigas");
            lista_nomes.Add("Flávio");
            lista_nomes.Add("Beatriz");
            lista_nomes.Add("Glória");
            lista_nomes.Add("Maria");
            lista_nomes.Add("Bia");
            lista_nomes.Add("Eduardo");
            lista_nomes.Add("Márcio");
            lista_nomes.Add("Miguel");
            lista_nomes.Add("Sarah");
            lista_nomes.Add("Saray");
            lista_nomes.Add("Larissa");
            lista_nomes.Add("Lucas");
            lista_nomes.Add("Guilherme");
            lista_nomes.Add("Maciel");
            #endregion

            #region Lista Números
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(5);
            lista_numeros.Add(8);
            lista_numeros.Add(54);
            lista_numeros.Add(57);
            lista_numeros.Add(2);
            lista_numeros.Add(3);
            lista_numeros.Add(15);
            lista_numeros.Add(12);
            lista_numeros.Add(7);
            #endregion

            #region Lista Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado USB", 49.95);
            lista_produtos.Add("Teclado PS2", 45.95);
            lista_produtos.Add("Teclado Gamer", 358.99);
            lista_produtos.Add("Mouse", 29.5);
            lista_produtos.Add("Monitor", 780.85);
            lista_produtos.Add("Memória 16Gb", 700.00);
            lista_produtos.Add("Memória 8Gb", 375.65);
            lista_produtos.Add("Processador", 1250);
            lista_produtos.Add("Placa Mãe", 623.75);
            lista_produtos.Add("Gabinete mATX", 150);
            lista_produtos.Add("Gabinete ATX", 190);
            #endregion

            #region Lista Estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de Janeiro", "Brasil");
            lista_estados.Add("New York", "Estados Unidos");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("Porto", "Portugal");
            lista_estados.Add("Lisboa", "Portugal");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Washington", "Estados Unidos");
            lista_estados.Add("Algarve", "Portugal");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //obter a fonte dos dados

            //criar a consulta

            //executar a consulta

            ////metodo comum
            //foreach (int num in lista_numeros)
            //{
            //    if (num % 2 == 0)
            //    {
            //        lista.Items.Add(num);
            //    }
            //}


            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            //foreach (int n in res)
            //{
            //    lista.Items.Add(n);
            //}
            string txt = txtPesquisa.Text;
            IEnumerable<string> res2 = from nome in lista_nomes
                                       where nome.StartsWith(txt)
                                       select nome;
               lista.Items.AddRange(res2.ToArray());
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //operador de filtragem, a clausula where
            string txt = txtPesquisa.Text;
            var res = from nome in lista_nomes where 
                      nome.ToLower().Contains(txt) 
                      select nome;
            foreach (var n in res)
            {
                lista.Items.Add(n);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //operador de ordenação
            string txt = txtPesquisa.Text;     //descendig/orderby
                                               // var res = from num in lista_numeros orderby num where num <= 10 select num;
          //  var res = from nome in lista_nomes orderby nome  descending select nome;
            //  foreach (var n in res)
            //{
            //    lista.Items.Add(n);
            //}
            var res = from produto in lista_produtos
                      orderby produto.Key
                      select produto;

            foreach (KeyValuePair<string, double> item in res)
            {
                lista.Items.Add(item.Key + "R$ " + item.Value);
            }
         

        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            txtPesquisa.Text = "";
            var res = from estado in lista_estados group estado by estado.Value;

            foreach (var grupo in res)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add("     "+estado.Key);
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            //int cont1 = lista_nomes.Count();
            //int cont2 = (from nomes in lista_nomes
            //              where nomes.StartsWith("G")
            //              select nomes).Count();
            //lista.Items.Add(cont1 + "nomes.");
            //lista.Items.Add(cont2 + "Nomes comçando com letra G");
            //double media1 = lista_numeros.Average();
            //lista.Items.Add(media1 + "media dos valores da lista numeros");

            //var res1 = from num in lista_numeros where num < 10 select num;
            //double media2 = res1.Average();
            //lista.Items.Add(media2 + "media dos valores menores que 10");

            //int soma1 = lista_numeros.Sum();
            //lista.Items.Add(soma1 + "soma dos valores");

            //var res2 = from num in lista_numeros where num < 10 select num;
            //int soma2 = res2.Sum();
            //lista.Items.Add(soma2 + "valores totais menores que 10");

            //lista.Items.Add(lista_numeros.Min() + "valor minimo da lista numeros");
            //lista.Items.Add(lista_numeros.Max() + "valor maximo da lista numeros");

            lista_numeros.LongCount();
            string maiorNome = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) =>
            {
                if (maior.ToString().Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
                
            });
            lista.Items.Add(maiorNome + "É o maior nome da lista");
        }

        private void btnOpElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            int primeiro = lista_numeros.FirstOrDefault();
            lista.Items.Add(primeiro);
            int ultimo = lista_numeros.LastOrDefault();
            lista.Items.Add(ultimo);
            int elementoEm = lista_numeros.ElementAtOrDefault(3);
            lista.Items.Add(elementoEm);

            var consulta = from num in lista_numeros where num > 1000 select num;
            int numero = consulta.FirstOrDefault();
            lista.Items.Add(numero);
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            //var cons1 = from nome in lista_nomes select nome;//comum
            //var cons1 = lista_nomes.Select(nome => nome);
            //lista.Items.AddRange(cons1.ToArray());
            //  var cons2 = from nome in lista_nomes where nome.StartsWith("G") select nome;
            //var cons2 = lista_nomes.Where(nome => nome.StartsWith("G"));
            //lista.Items.AddRange(cons2.ToArray());

            //var cons3 = from nome in lista_nomes orderby nome select nome;
            //lista.Items.Add(cons3.ToArray());
            //var cons3L = lista_nomes.OrderBy(nome => nome);
            //var cons3L2 = lista_nomes.OrderByDescending(nome => nome);
            //lista.Items.AddRange(cons3L.ToArray());

            var cons4 = from estado in lista_estados group estado by estado.Value;
            var cons4L = lista_estados.GroupBy(estado => estado.Value);

            foreach (var grupo in cons4L)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add("GRUPO: " + estado.Key);
                }
                    
            }

        }
    }
}
