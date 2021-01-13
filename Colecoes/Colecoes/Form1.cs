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
           //     listaBox.Items.Add(item.Value);
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
            _ = MessageBox.Show("ultimo" + alunos.Last().Key + " " + alunos.Last().Value);

        }
    }
}
