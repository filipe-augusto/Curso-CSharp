using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CriptoFile
{
    class Criptografia
    {
        //declaração de CspParmeters  e RsaCryptoServiceProvider
        //objetos com escopo global na classe
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        //caminhos variaveis para a fonte, pasta de criptografia
        //e pasta de descriptografia
        private static string _encrFolder;
        public static string EncrFolder
        {
            get
            {
                return _encrFolder;
            }
            set
            {
                _encrFolder = value;
                PubKeyFile = _encrFolder + "rsaPublicKey.txt";
            }
        }

        public static string DecrFolder { get; set; }
        public int SrcFolder { get; set; }

        //arquivo de chave publica
        private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

        //chave contendo o nome para private/public key value pair
        public static string KeyName;
        //metodo para criar a chave publica
        public static string CreatAsmKeys()
        {
            string result = "";
            //armazenar uma key pair na key container
            if (string.IsNullOrEmpty(KeyName))
            {
                result = "Chave publica não definida";
                return result;
            }
            cspp.KeyContainerName = KeyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " -Somente publica";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key pair completa";
            }


            return result;
        }
        //metodo para exportar a chave publica em um arquivo
        public static bool ExportPublicKey()
        {
            bool result = true;
            if (rsa == null)
            {
                return false;
            }
            if (!Directory.Exists(EncrFolder))
            {
                Directory.CreateDirectory(EncrFolder);
            }
            StreamWriter sw = new StreamWriter(PubKeyFile, false);

            try
            {
                sw.Write(rsa.ToXmlString(false));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                sw.Close();
            }
            return result;

        }
        //metodo para importar a chave publica de um arquivo
        public static string ImportPublicKey()
        {
            string result = "";
            if (File.Exists(PubKeyFile))
            {
                result = "Arquivo de chave publica não encontrada";
                return result;
            }

            if (string.IsNullOrEmpty(KeyName))
            {
                result = "Chave publica não definida";
                return result;
            }
            return result;
        }

    }
}

