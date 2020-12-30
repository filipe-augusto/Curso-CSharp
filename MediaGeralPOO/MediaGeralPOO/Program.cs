using System;

namespace MediaGeralPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Media geral dos alunos ###";
            Console.Write("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for(int i =0; i < alunos.Length; i++)
            {
                Console.Clear(); //limpa a tela
                Console.Write("Aluno #" + (i + 1)+ " Nome ..: "); 
                string nome = Console.ReadLine(); //pega nome

                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                int provas = int.Parse(Console.ReadLine()); //pega nota

                alunos[i] = new Aluno(nome, provas); //

                Console.WriteLine("insra as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }
            Console.Clear();

            double mediaGeral = 0;

            foreach(var aluno in alunos)
            {
                Console.WriteLine(" Aluno: " + aluno.Nome);
                Console.WriteLine(" Media: " + aluno.Media);
                mediaGeral += aluno.Media;
            }
            double resultadoFinal = mediaGeral / alunos.Length;
            Console.WriteLine("Media geral dos alunos: "+resultadoFinal);
            Console.ReadLine();
        }
    }
}
