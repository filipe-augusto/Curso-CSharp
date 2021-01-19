using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listaBox.Items.Clear();
            string[] nomes = new string[3];
            nomes[0] = "Filipe";
            nomes[1] = "arthur";
            nomes[2] = "Danny";

            List<string> nomes2 = new List<string>();
            nomes2.Add("Lucas");
            nomes2.Add("Beatriz");
            nomes2.AddRange(nomes);
            //adiciona um array na lista
            //if (nomes2.Remove("Lucas"))//remove
            //{
            //    MessageBox.Show("Lucas removido");
            //}
            //else
            //{
            //    MessageBox.Show("não foi possivel remover");
            //}
            //if (nomes2.Contains("Filipe"))
            //{
            //    MessageBox.Show("contém!");
            //}
            //else
            //{
            //  MessageBox.Show("não contém!");
            //}
            //listaBox.Items.Add(nomes2[1]);
            //listaBox.Items.Add(nomes2[0]);
            //listaBox.Items.AddRange(nomes);
            // MessageBox.Show("Numero de elementos: " + nomes2.Count);//conta quantos elementos tem
            //nomes2.Sort();
            // MessageBox.Show($"Filipe esta no indice: {nomes2.IndexOf("Filipe")}");  
            // nomes2.Insert(2, "Joao");
            nomes2.RemoveAt(1);

            foreach (string nome in nomes2)
            {
                listaBox.Items.Add(nome);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaBox.Items.Clear();
            HashSet<string> veiculos = new HashSet<string>()//hashSet nao aceita adicionar um item que ja tem na lista
            { 
                "Carro","Moto","Avião","Helicoptero", "Barco"
            };
            MessageBox.Show(veiculos.ElementAt(2));
            MessageBox.Show(veiculos.First());
            MessageBox.Show(veiculos.Last());
            //if (veiculos.Add("Cavalo"))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            foreach (string item in veiculos)
            {
                listaBox.Items.Add(item);
            }

        }

        private void btnDicionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            { { 150, "Cassila"},  {200,"Filipe"}, {800,"Cassila"}
            };
            alunos.Add(100, "Joao");

            //foreach(KeyValuePair<int, string> item in alunos)
            //{
            //    listaBox.Items.Add(item);
            //}
            foreach (KeyValuePair<int, string> item in alunos)
            {
              listaBox.Items.Add(item.Value);
              //  listaBox.Items.Add(item.Key);
            }
           // if (alunos.ContainsValue("Joel"))
                if (alunos.ContainsKey(80))
            {
                MessageBox.Show("Contem a chave 80");
            }
            else
            {
                MessageBox.Show("Nao contem a chave 80");
            }

         //   MessageBox.Show("Quantidade de alunos" + alunos.Count);
           // MessageBox.Show("Quantidade de alunos" + alunos.Remove(200));
           // alunos.Clear();
           // _ = MessageBox.Show("ultimo" + alunos.Last().Key + " " + alunos.Last().Value);

        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            listaBox.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27,"Filipe"},
                { 30, "CAssila"},
                { 12, "augusto"}
            };
            alunos.Add(14, "Floria");
            alunos.Remove(10);
            //alunos.Reverse()

            foreach (KeyValuePair<int, string> item in alunos)
            {
                listaBox.Items.Add(item.Key + " " + item.Value);
            }
        }
        private void SortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {1233,"Filipe" },
                {14412,"August" },
                {2344,"Danny" }
            };
            alunos.Add(1234, "Flavio");
            // alunos.Remove(120);
            _ = alunos.Count;
            alunos.ContainsKey(1542);
            alunos.ContainsValue("danny");      
            foreach(KeyValuePair<int, string> item in alunos)
            {
                listaBox.Items.Add(item);
            }

        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            listaBox.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Filipe","Joel", "Cassila", "Breno"
            };
            nomes.First();
            nomes.Last();
            nomes.Max();
            nomes.ElementAt(1);
            MessageBox.Show(nomes.Max());

            foreach(string nome in nomes)
            {
                listaBox.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Filipe");
            fila.Enqueue("Casisla");
            fila.Enqueue("Cristina");
            MessageBox.Show(fila.Count.ToString());
            fila.Peek();//primeiro da fila
            fila.Dequeue(); //aponta o primeiro da fila e remove
            fila.First();
            foreach(string item in fila)
            {
                listaBox.Items.Add(item);
            }
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            //pilha primeiro a entrar é o ultimo a sair
            listaBox.Items.Clear();
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Isaac");
            pilha.Push("Filipe");
            pilha.Push("Cassila");
           // MessageBox.Show(pilha.Count.ToString());
            foreach(string item in pilha)
            {
                listaBox.Items.Add(item);
            }
          //  MessageBox.Show(pilha.Peek());//sem remove-lo da pilha
            MessageBox.Show("elemento no topo" + pilha.Pop());//e remove
        }
    }
}
