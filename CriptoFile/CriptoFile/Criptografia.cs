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
            StreamReader sr = new StreamReader(PubKeyFile);
            try
            {
                cspp.KeyContainerName = KeyName;
                rsa = new RSACryptoServiceProvider(cspp);
                string keytxt = sr.ReadToEnd();
                rsa.FromXmlString(keytxt);
                rsa.PersistKeyInCsp = true;
                if (rsa.PublicOnly)
                {
                    result = "Key: " + cspp.KeyContainerName + "- Somente publica";
                }
                else
                {
                    result = "Key: " + cspp.KeyContainerName + "- Key pair completa";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Console.WriteLine(ex.Message);
               
            }
            finally
            {
                sr.Close();
            }
            return result;

        }
        //metodo para criar uma chave privada a partir de um valor definido
        public static string GetPrivateKey()
        {
            string result = "";
            if (string.IsNullOrEmpty(KeyName))
            {
                result = "chave privada não definida";
                return result;
            }
            cspp.KeyContainerName = KeyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + "- Somente publica";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + "- Key pair completa";
            }
            return result;
        }

        //metodo para criptografar um arquivo

        public static string EncryptFile(string inFile)
        {
            //criar instancia de Aes para criptografia simetrica dos dados
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();
            //use  RSACCryptoServiceProvider para criptografar a chave AES
            //rsa é instaciado anteriormente: rsa = new RSACryptoServiceProvider(cspp)

            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);
            //criar matrizes de bytes para conter
            //os valores de comprimento da chave IV
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);
            //escreva o seguinte fileStream
            //para o arquivo criptografado(outFs)
            //comprimento da chave
            //comprimento do IV
            //chave criptografada
            //o conteudo da cifra cripgrafada
            int startFileName = inFile.LastIndexOf("\\") + 1;
            string outFile = EncrFolder + inFile.Substring(startFileName) + ".enc";
            try
            {
                using(FileStream outFs = new FileStream(outFile, FileMode.Create))
                {
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(LenK, 0, 4);
                    outFs.Write(keyEncrypted, 0, lKey);
                    outFs.Write(aes.IV, 0, lIV);
                    //agora escreva o texto crifrado usando um cryptoStream para criptografar
                    using (CryptoStream cryptoStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        //ao criptogradar um pedaço por vez, voce pode economizar memoria
                        int count = 0;
                        int offset = 0;
                        //blockSizeBytes pode ter qualquer tamanho arbitrario
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] date = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFs = new FileStream(inFile, FileMode.Open) )
                        {

                        }
                    }
                }
            }catch (Exception ex)
            {
                return ex.Message;
            }
            return $"Arquivo criptografado.\n Origem: {inFile}\n Destino: {outFile}";
        }
        //metodo para descriptografar um arquivo

    }
}

