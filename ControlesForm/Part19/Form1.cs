using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MontarTree();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //string nome = treeView1.SelectedNode.Text;
            //MessageBox.Show(nome);
        }

        private void MontarTree()
        {

            treeView1.BeginUpdate();
            treeView1.Nodes.Add("nomes");
 
            treeView1.Nodes[0].Nodes.Add("Filipe");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Augusto");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Santos");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Chaves");
            treeView1.Nodes[0].Nodes.Add("Pedro");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Isaac");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Santos");
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes[0].Nodes.Add("Chaves");

            treeView1.Nodes[0].Nodes.Add("Cassila");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Nascimento");
            treeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add("Fonseca");
            treeView1.Nodes[0].Nodes.Add("Maria");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("Eunice");
            treeView1.Nodes[0].Nodes[3].Nodes[0].Nodes.Add("Santos");
            treeView1.Nodes[0].Nodes[3].Nodes[0].Nodes[0].Nodes.Add("Chaves");
            treeView1.EndUpdate();
        }
    }
}
