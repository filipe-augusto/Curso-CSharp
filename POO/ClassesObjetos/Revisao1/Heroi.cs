using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao1
{
    class Heroi
    {
        //nome, genero, pais, forca, vitalidade, defesa

        public string nome;
        public char genero;
        public string pais;
        public int forca;
        public int vida;
        public int defesa;

        public Heroi(string nome, char genero, string pais, int forca, int vida, int defesa )
        {
            this.nome = nome;
            this.genero = genero;
            this.pais = pais;
            this.forca = forca;
            this.vida = vida;
            this.defesa = defesa;
        }
     
        public int Luta(int ataqueRecebido,ref int vida)
        {
            vida += this.defesa;
            vida -= ataqueRecebido;
            return vida;
        }



    }
}
