using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Triangulo.Entities;
using Triangulo.Entities.Enums;

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
            // Console.Write("How many employess will be registered?dd ");
            //  int amountEmployess = int.Parse(Console.ReadLine());
            // Employess employes;
            //for(int i =0; i<amountEmployess; i++)
            // {
            //     Console.WriteLine("========================");
            //     Console.Write("Type a Id: ");
            //     int id = int.Parse(Console.ReadLine());
            //     Console.Write("Type a name: ");
            //     string name = Console.ReadLine();
            //     Console.Write("Type a salary: ");
            //     double salary = double.Parse(Console.ReadLine());
            //     employes = new Employess()
            //     {
            //         Id = id,
            //         Name = name,
            //         Salary = salary
            //     }; 
            // }
            // for (int i = 0; i < amountEmployess; i++)
            // {


            // }

            #endregion
            #region matriz
            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length);//matanho
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));


            #endregion
            #region exercicio matriz
            //int n = int.Parse(Console.ReadLine());
            //int[,] mat = new int[n, n];

            //for(int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');

            //  for(int j =0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            #endregion
            #region VAR - 24/01
            //var x = 10;
            //var y = "mria";
            ////var aceita tudo
            #endregion
            #region switch and case
            //int x = int.Parse(Console.ReadLine());
            //string day;

            //switch (x)
            //{
            //    case 1:
            //        day = "monday";
            //        break;
            //    case 2:
            //        day = "tuesday";
            //        break;
            //    case 3:
            //        day = "Wednesday ";
            //        break;
            //    case 4:
            //        day = "Thursday  ";
            //        break;
            //    case 5:
            //        day = "Friday   ";
            //        break;
            //    default:
            //        day = "Invalido";
            //        break;
            //}
            //Console.WriteLine(day);
            #endregion
            #region ternario
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto = preco < 20 ? preco * 0.1 : preco * 0.2;
            //Console.WriteLine(desconto);

            #endregion
            #region funções de string
            //string original = "avsdbcosd osdjfsdofjsd aSDOFSD BSDOFJDSF SDbcOFJSDFSDF     ";
            //string s1 = original.ToUpper(); //maiusculo
            //string s2 = original.ToLower(); //minusculo
            //string s3 = original.Trim();//tira os espaços em branco
            //                            // Console.WriteLine(s3 + "-");
            //int n1 = original.IndexOf("bc");//primeira ocorrencia
            //int n2 = original.LastIndexOf("bc");//ultima ocorrencia

            //string s4 = original.Substring(3); //mostra a string cortada apartir do numero passado
            //string s5 = original.Substring(3, 5); // mostra um pedaço da string conforme os parametros
            //string s6 = original.Replace('a', '4');//troca as letras
            //string s7 = original.Replace("avsdbcosd", "primeiro");//troca as palavras
            //bool b1 = String.IsNullOrEmpty(original);//se é nulo ou vazio
            //bool b2 = String.IsNullOrWhiteSpace(original); //se é nulo ou tem espaços em brancos


            //Console.WriteLine("original: -"+original+"-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("IndexOf: -" + n1 + "-");
            //Console.WriteLine("LastIndexOf: -" + n2 + "-");
            //Console.WriteLine("Substring(3): -" + s4 + "-");
            //Console.WriteLine("Substring(3,5): -" + s5 + "-");
            //Console.WriteLine("Replace('a','4'): -" + s6 + "-");
            //Console.WriteLine("Replace('avsdbcosd','primeiro'): -" + s7 + "-");
            //Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            //Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");


            #endregion
            #region DateTime
            //            DateTime d1 =  DateTime.Now;//agora
            //            DateTime d2 = new DateTime(2018, 11, 25);//ano- mes-dia
            //            DateTime d3 = new DateTime(2018, 11, 25,20,45,03);//ano- mes-dia e horas
            //            DateTime d4 = DateTime.Today;
            //            DateTime d5 = DateTime.Parse("2000-08-15");
            //            DateTime d6 = DateTime.Parse("15/08/2000");
            //            // DateTime d7 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd");
            //            // DateTime d8 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //               DateTime d8 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            //CultureInfo.InvariantCulture);
            //            Console.WriteLine(d1);
            //            Console.WriteLine(d2);
            //            Console.WriteLine(d3);
            //            Console.WriteLine(d4);
            //            Console.WriteLine(d5);
            //            Console.WriteLine(d6);
            //          //  Console.WriteLine(d7);
            //            Console.WriteLine(d8);

            #endregion
            #region TimeSpan
            //TimeSpan t1 = new TimeSpan(0, 1, 30);//hora e minutos
            //TimeSpan t2 = new TimeSpan(90000000L);
            //TimeSpan t3 = new TimeSpan(1,2,11,21);//dia, hora e minutos
            //TimeSpan t4 = TimeSpan.FromDays(1.5);
            //TimeSpan t5 = TimeSpan.FromHours(48);
            //TimeSpan t6 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t7 = TimeSpan.FromTicks(90000000000L);
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);
            //Console.WriteLine(t7);

            #endregion
            #region DateTime operações
            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);
            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();
            //string s5 = d.ToString();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);
            //DateTime x = new DateTime(2001, 10, 15, 13, 45, 58, 275);
            //DateTime x2 = new DateTime(2001, 9, 20, 13, 45, 58, 275);
            //TimeSpan y = x.Subtract(x2);
            //DateTime y = x.AddDays(double);
            //DateTime y = x.AddHours(double);
            //DateTime y = x.AddMilliseconds(double);
            //DateTime y = x.AddMinutes(double);
            //DateTime y = x.AddMonths(int);
            //DateTime y = x.AddSeconds(double);
            //DateTime y = x.AddTicks(long);
            //DateTime y = x.AddYears(int);
            //DateTime y = x.Subtract(timeSpan);
            //TimeSpan t = x.Subtract(dateTime);

            //  Console.WriteLine(y);

            #endregion
            #region DateTime operações
            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t);
            //Console.WriteLine("Days: " + t.Days);
            //Console.WriteLine("Hours: " + t.Hours);
            //Console.WriteLine("Minutes: " + t.Minutes);
            //Console.WriteLine("Milliseconds: " + t.Milliseconds);
            //Console.WriteLine("Seconds: " + t.Seconds);
            //Console.WriteLine("Ticks: " + t.Ticks);
            //Console.WriteLine("TotalDays: " + t.TotalDays);
            //Console.WriteLine("TotalHours: " + t.TotalHours);
            //Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);
            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);


            #endregion
            #region dateTimeKinid
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            //Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            //DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            //Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            #endregion
            #region ENUM
            //// Console.Write(order);
            //Order order = new Order();
            //order.Id = 1080;
            //order.Moment = DateTime.Now;
            //order.Status = OrderStatus.PendingPayment;
            //Console.WriteLine(order);

            #endregion
            Console.ReadLine();
        }
  

       
      
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


