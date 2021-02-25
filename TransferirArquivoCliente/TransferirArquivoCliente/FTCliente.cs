using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    class FTCliente
    {
        static IPEndPoint ipEnd_cliente;
        static Socket clienteSock_cliente;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortHost = 1000;
        //public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 
        //    + @"\";
        // public static Label LabelMensagem;
        public static System.Windows.Forms.Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {
                ipEnd_cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortHost);
                clienteSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta += arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);
                if (nomeArquivoByte.Length > 50000 * 1024)
                {
                    LabelMensagem.Invoke(new Action(() =>
                    {
                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "O tamanho do arquivo é maior que 50Mb, tente um arquivo menor.";
                    }));
                    return;
                }

                string caminhoCompleto = pasta + arquivo;

                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);
                clienteSock_cliente.Connect(ipEnd_cliente);
                clienteSock_cliente.Send(clientData, 0, clientData.Length, 0);
                clienteSock_cliente.Close();
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Green;
                    LabelMensagem.Text = "Arquivo [" + arquivo + "] transferido.";
                }));
            }
            catch (Exception ex)
            {
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = "Falha, O Servidor não esta atendendo....\n" + ex.Message;
                }));
            }
            finally
            {
                clienteSock_cliente.Close();
            }
        }

    }
}
