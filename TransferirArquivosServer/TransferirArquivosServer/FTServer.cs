﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivosServer
{
    class FTServer
    {
        static IPEndPoint ipEnd_servidor;//defirnir o ponto de conexão com o server
        static Socket sock_Servidor;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static ListBox ListaMensagem;
        public static void IniciarServidor()
        {
            try
            {
                ipEnd_servidor = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                sock_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock_Servidor.Bind(ipEnd_servidor);
            }
            catch (Exception ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao iniciar o servidor : " + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
                return;
            }

            try
            {
                sock_Servidor.Listen(1000);
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Servidor em atendimento e aguardano para receber arquivo....: ");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
                Socket clienteSock = sock_Servidor.Accept();
                clienteSock.ReceiveBufferSize = 16384;

                byte[] dadosCliente = new byte[1024 * 5000];
                int tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
           
                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);
                BinaryWriter bwrite = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArquivo, FileMode.Append));
                bwrite.Write(dadosCliente, 4 + tamanhoNomeArquivo,
                    tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo);
                while (tamanhoBytesRecebidos > 0)
                {
                    tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                    if (tamanhoBytesRecebidos == 0)
                    {
                        bwrite.Close();
                    }
                    else
                    {
                        bwrite.Write(dadosCliente, 0, tamanhoBytesRecebidos);
                    }           
                }
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Arquivo foi recebido e arquivado [" + nomeArquivo + "] ");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
                bwrite.Close();
                clienteSock.Close();
            }
            catch (SocketException ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao receber o arquivo:\n "+ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
            }
            finally
            {
                sock_Servidor.Close();
                sock_Servidor.Dispose();
                IniciarServidor();
            }
        }
    }
}