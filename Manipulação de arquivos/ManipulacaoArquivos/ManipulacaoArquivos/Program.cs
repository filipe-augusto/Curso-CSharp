using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("arquivos");
            try
            {

                //CreateText - Sobrescreve o conteúdo do arquivo com um texto informado.
                const string filePath = @"C:/dev/meuarquivo.txt";
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("Sobrescreve o conteúdo do arquivo com um texto informado.");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");

                }
                //AppendText - Adiciona um texto ao fim do arquivo
                //manipular arquivos grandes, você não precisa ler o arquivo completamente para adicionar conteúdo ao mesmo.
                //Neste caso é preferível utilizar o ((AppendText))
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine("adiciona o texto ao fim do arquivo");//
                };

                //COPIAR
                CopiarArquivo(filePath);

                //MOVER
                //  MoverArquivo(filePath);

                //SUBSTITUIR
                //  SubstituirArquivo(filePath);

                //EXCLUIR
                //   File.Delete(filePath);

                //VERIFICAR SE ARQUIVO EXISTE
                VerificarSeArquivoExiste(filePath);

                //OBTER A DATA DA ULTIMA MODIFICAÇÃO;
                ObterDataDaUltimaModificacao(filePath);


            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO:" + ex.Message);
            }
            Console.ReadKey();
        }

        public static void CopiarArquivo(string caminho)
        {
            try
            {
                //   File.Copy(caminho, $@"C:\dev\NOVO ARQUIVO-{DateTime.Now.Second}.txt");

                if (!File.Exists($@"C:\dev\outro.txt"))
                {
                    File.Copy(caminho, $@"C:\dev\outro.txt");
                }
                else
                {
                    Console.WriteLine("ARQUIVO JA EXISTE. NAO É POSSIVEL COPIAR");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("ERRO PARA COPIAR");
            }
        }

        public static void MoverArquivo(string caminho)
        {

            try
            {
                File.Move(caminho, $@"C:\dev\temp\NOVO CAMINHO-{DateTime.Now.Second}.txt");
            }
            catch
            {
                Console.WriteLine("ERRO PARA MOVER");
            }
        }

        public static void SubstituirArquivo(string caminho)
        {
            try
            {
                File.Replace(@"C:\dev\outro.txt", caminho, @"C:\dev\backup.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO PARA SUBUSTITUIR ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }

        public static void VerificarSeArquivoExiste(string caminho)
        {
            if (File.Exists(caminho))
            {
                Console.WriteLine("ARQUIVO EXISTE");
            }
            else
            {
                Console.WriteLine("ARQUIVO NAO EXISTE");
            }
        }

        public static void ObterDataDaUltimaModificacao(string caminho)
        {
            if (File.Exists(caminho))
            {
                var time = File.GetLastAccessTime(caminho);
                Console.WriteLine(time);
            }
        }
   
        public static void ObterAtributosDoArquivo(string caminho)
        {
            var attrs = File.GetAttributes(caminho);
            if ((attrs & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                Console.WriteLine("read-only");

            if ((attrs & FileAttributes.Compressed) == FileAttributes.Compressed)
                Console.WriteLine("compressed");
        }
    }
}
