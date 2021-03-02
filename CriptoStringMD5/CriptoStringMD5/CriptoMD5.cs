using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CriptoStringMD5
{    class CriptoMD5
    {
        public string RetornarMD5(string senha)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return RetornarHash(md5Hash, senha);
            }
        }

        public bool CompararMD5(string senhaEntrada, string senhaMD5)
        {
            string senha = RetornarMD5(senhaEntrada);
            if (VerificarHash(senhaMD5, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string RetornarHash(MD5 md5Hash,string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sbuilder.Append(data[i].ToString("X2"));
            }
            return sbuilder.ToString();
        }

        private bool VerificarHash(string input, string hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            if (comparar.Compare(input, hash)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
