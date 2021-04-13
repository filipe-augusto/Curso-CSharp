using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static double PI = 3;

        static void Main(string[] args)
        {
            //ORDEM SUGERIDA
            //ATRIBUTOS PRIVADOS
            //PROPRIEDADES AUTOIMPLEMENTADAS
            //CONSTRUTORES
            // PROPRIEDADES CUSTOMIZADAS
            //OUTROS METODOS DA CLASSE
            ///------------------------------------modificadores de acesso
            /// public - pode ser acessado por tudo
            /// protected  internal - tudo menos classes fora do projeot
            /// internal - menos subclasses fora do projeto
            /// protected -  menos classes do projeto e classes fora do projeto
            /// private  - protected so podem acessar a propria classe e as subclasses
            /// private - so a propria classe pode acessar 
            #region  exercicio 1
            //Pessoa a1 = new Pessoa();
            //Pessoa a2 = new Pessoa();
            //a1.Nome = "Filpe";
            //a1.Idade = 27;
            //a2.Nome = "Augusto";
            //a2.Idade = 26;

            //if(a1.Idade > a2.Idade)
            //{
            //    Console.WriteLine(a1.Nome + " é mais velho");

            //}
            //else
            //{
            //    Console.WriteLine(a2.Nome + " é mais velho");
            //}
            //Console.ReadKey();
            #endregion
            #region exercicio 2
            //Funcionariocs f1 = new Funcionariocs();
            //Funcionariocs f2 = new Funcionariocs();
            //f1.Nome = "Filipe";
            //f1.Salario = 500;
            //f2.Nome = "Augusto";
            //f2.Salario = 600;

            //if (f1.Salario > f2.Salario) {
            //    Console.WriteLine($"{f1.Nome} tem o salario maior");
            //}
            //else
            //{
            //    Console.WriteLine($"{f2.Nome} tem o salario  maior");

            //}
            //Console.ReadKey();
            #endregion
            #region objecto
            //Produto p = new Produto();
            //Console.WriteLine("entre com os dados do produto");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade do estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser adicionado");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser removidos: ");
            // qte = int.Parse(Console.ReadLine());
            //Console.ReadKey();
            //Console.WriteLine("Dados atualizados: " + p);

            #endregion
            #region membros estaticos
            //Console.Write("Entre o valor do raio:");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double circ = Circunferencia(raio);
            //double volume = Volume(raio);

            //Console.WriteLine("circunferencia: "+circ);
            //Console.WriteLine("Volume: " + volume);
            //Console.ReadKey();
            #endregion
            #region membros estaticos 2   
            //Console.Write("Entre o valor do raio:");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double circ = Calculadora.Circunferencia(raio);
            //double volume = Calculadora.Volume(raio);
            //Console.WriteLine("circunferencia: " + circ.ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine("Vo
            //   lume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadKey();
            #endregion
            #region construtor           
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade do estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidade);
            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser adicionado");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser removidos: ");
            //qte = int.Parse(Console.ReadLine());
            //Console.ReadKey();
            //Console.WriteLine("Dados atualizados: " + p);
            #endregion
            #region sobrecarga
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade do estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco);//sobrecarga -- usou o outro constutor
            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser adicionado");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine("Dados do produto: " + p);
            //Console.Write("Digite o numero de produtos a ser removidos: ");
            //qte = int.Parse(Console.ReadLine());
            //Console.ReadKey();
            //Console.WriteLine("Dados atualizados: " + p);
            #endregion
            #region sintaxe alternativa
            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.Write("Preço: ");
            //    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Quantidade do estoque: ");
            //    int quantidade = int.Parse(Console.ReadLine());       
            //    Produto p = new Produto(nome, preco, quantidade);
            //    //SINTAXE ALTERNATIVA
            //    Produto p2 = new Produto{//funciona mesmo que nao tenha constutor
            //        Nome = "playstation 5",
            //        Preco = 5000.00,
            //        Quantidade =5
            //};
            //    Console.WriteLine("Dados do produto: " + p);
            //    Console.Write("Digite o numero de produtos a ser adicionado");
            //    int qte = int.Parse(Console.ReadLine());
            //    p.AdicionarProdutos(qte);
            //    Console.WriteLine("Dados atualizados: " + p);

            //    Console.WriteLine("Dados do produto: " + p);
            //    Console.Write("Digite o numero de produtos a ser removidos: ");
            //    qte = int.Parse(Console.ReadLine());
            //    Console.ReadKey();
            //    Console.WriteLine("Dados atualizados: " + p);
            #endregion
            #region palavra this
            //difereciar atributos de variaveis locais
            //referenciar outro constutor em um constutor
            //passar o proprio objeto como argumento na chamada de um metodo ou construtor
            #endregion
            #region encapsulamento
            //ProdutoUsandoEncapsulamento p = new ProdutoUsandoEncapsulamento("TV", 500.00, 10);
            //Console.WriteLine(p.GetNome());
            //p.SetNome("Tv 4k");


            #endregion
            #region     propriedade
            // ProdutoUsandoPropriedades p = new ProdutoUsandoPropriedades();
            // p.Nome = "geladeira";
            //int quant = p.Quantidade;
            //double preco =  p.Preco;
            #endregion
            #region exercicio OO
            //ContaBancaria p1 = new ContaBancaria("Filipe", 471993 - 2020, 55.00);

            //ContaBancaria p1;
            //Console.Write("Nome do titular: ");
            //string nome = Console.ReadLine();
            //Console.Write("Numero da conta do titular: ");
            //int conta = int.Parse(Console.ReadLine());

            //Console.WriteLine("Haverá deposito inicial? (s/n)");
            //char resp1 = char.Parse(Console.ReadLine());
            //if (resp1 == 's' || resp1 == 'S')
            //{
            //    Console.Write("Entre com o deposito inicial: ");
            //    double depositoInicial = double.Parse(Console.ReadLine());
            //    p1 = new ContaBancaria(nome, conta, depositoInicial);
            //    Console.WriteLine(p1.dadosDaConta());
            //}
            //else
            //{
            //    p1 = new ContaBancaria(nome, conta);
            //    Console.WriteLine(p1.dadosDaConta());
            //}

            //Console.WriteLine("Valor do deposito: ");
            //double d = double.Parse(Console.ReadLine());
            //Console.WriteLine(p1.deposito(d));
            //Console.WriteLine("Valor do saque: ");
            //double s = double.Parse(Console.ReadLine());
            //Console.WriteLine(p1.saque(s));
            //Console.ReadKey();
            #endregion
            #region Struct
            //Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);
            //p = new Point();
            //Console.WriteLine(p);
            #endregion
            #region garbage collecot
            //quando o objeto perde a referencia o garbage coolector irá deslocado-lo
            #endregion
            #region nullable
            //double? x  = null;
            //double? y = 10;
            //Console.WriteLine(x.GetValueOrDefault()); //peg ao valor que tem e caso seja nulo pega o valor de 0
            //Console.WriteLine(y.GetValueOrDefault());
            //Console.WriteLine(x.HasValue); //dentro da variavel existe valor?
            //Console.WriteLine(y.HasValue); //tem o valor

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X  is null");
            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("y  is null");
            ////------------ operador de coalescencia nula
            //double yy = x ?? 0.0; //se o valor de x for nulo ele joga o que tiver na direita
            #endregion
            #region vetor1
            //int n = int.Parse(Console.ReadLine());
            //double[] vetor = new double[n];

            //for(int i = 0; i < n; i++)
            //{
            //    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //double sum=0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += vetor[i];
            //}
            //Console.WriteLine(sum / n);
            #endregion
            #region vetor2
            // int n = int.Parse(Console.ReadLine());
            // Produto2[] vetor = new Produto2[n];
            // for(int i = 0; i< n; i++)
            // {
            //     string nome = Console.ReadLine();
            //     double price = double.Parse(Console.ReadLine(),CultureInfo.InstalledUICulture);
            //     vetor[i] = new Produto2 { Name = nome, Price = price };
            // }
            // double soma = 0;
            //// Console.WriteLine(vetor);
            // for (int i = 0; i < n; i++)
            // {
            //     soma += vetor[i].Price;
            // }
            // double avg = soma / n;
            // Console.WriteLine("Preço medio = " + avg.ToString());

            #endregion
            #region exercicio vetor
            //Console.Write("Digite a quantidade de  quartos que você  deseja alugar: ");
            //int rooms = int.Parse(Console.ReadLine());
            //Estudante[] estudantes = new Estudante[rooms];
            //for (int i = 0; i < rooms; i++)
            //{
            //    Console.Write($"Digite o nome do estudante para o quarto {i +1}: ");
            //    string nome = Console.ReadLine();
            //    Console.Write($"Digite o e-mail do estudante para o quarto {i+1}: ");
            //    string email = Console.ReadLine();
            //    estudantes[i] = new Estudante { Nome = nome, Email = email };
            //}
            //for (int i = 0; i < rooms; i++)
            //{
            //    if (estudantes[i] != null)
            //    {
            //        Console.WriteLine($"{i+1} - Nome: {estudantes[i].Nome} - {estudantes[i].Email}.");
            //    }
            //}
            #endregion
            #region moficadores de parametros params
            //int s1 = Calculator.Sum( 2, 3 ); //using  params in class calculator
            //int s2 = Calculator.Sum(new int[] { 2,4, 3 });
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            #endregion
            #region modificadores de acesso ref ou out
            //int a = 10;
            //Calculator.Triple( ref a); //referencia a variavel e não usa somente como parametro. 
            ////Mas é obrigatorio que a variavel ja receba um valor
            //int b = 5;
            //int c;
            //Calculator.Triple(b , out c); //onde se é o resultado de saida(retorno)
            //Console.WriteLine("Usando ref: "+ a);
            //Console.WriteLine("Usando out: " + c);
            ////ref - deve ter sido iniciada
            ////out - nao precisa ter sido iniciada
            ////ambos sao similares - design ruim(e devem ser evitadas)
            #endregion
            #region boxing and unboxing
            //memoria
            //- stack(pilha) - uma forma otimizada para organizar dados na memória alocados em sequência e abandonados
            //disponibiliza para execução de seu programa / tamanho limitado(alguns megas).
            // - heap
            //-  a organização de memória mais flexível que permite o uso de qualquer área lógica disponível.
            //boxing - tem um custo maior de memoria
            //int x = 20;
            //Object obj = x;
            //// unboxing
            //int y = (int )obj;

            #endregion
            #region for each
            //string[] vect = new string[] { "Maria", "alex", "Bob" };
            //foreach(string obj in vect)
            //{
            //    Console.WriteLine(obj);
            //}
            #endregion
            #region listas
            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna"); //added last position
            //list.Insert(2,"Filipe");//added position 2
            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine("List count" + list.Count);
            //string s1 = list.FindLast(x => x[0]=='A');
            //Console.WriteLine("First 'A': " + s1);
            //string s2 = list.Find(x =>x[0] == 'A');
            //Console.WriteLine("Last 'A'"+s2);
            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("first position 'A': " + pos1);
            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("last position 'A': " + pos2);

            //List<string> list2 = list.FindAll(x => x.Length == 5);

            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //list.Remove("Alex");//remove an element by name
            //list.RemoveAll(x => x[0] == 'M'); //remove all with a condition declared
            //list.RemoveAt(2);//remove by position
            //list.RemoveRange(2, 2); //after position 2 remove 2 elements
            #endregion
            #region exercises list
            Console.Write("How many employess will be registered?dd ");
             int amountEmployess = int.Parse(Console.ReadLine());
            Employess employes;
           for(int i =0; i<amountEmployess; i++)
            {
                Console.WriteLine("========================");
                Console.Write("Type a Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Type a name: ");
                string name = Console.ReadLine();
                Console.Write("Type a salary: ");
                double salary = double.Parse(Console.ReadLine());
                employes = new Employess()
                {
                    Id = id,
                    Name = name,
                    Salary = salary
                }; 
            }
            for (int i = 0; i < amountEmployess; i++)
            {


            }

                #endregion

                Console.ReadLine();
        }
        #region membros estaticos
        //static double Circunferencia(double r)
        //{
        //    return 2*PI * r;
        //} 

        //static double Volume(double r)
        //{
        //    return 4.0 / 3.0 * PI * r * r * r;
        //}
        #endregion

    }
}
