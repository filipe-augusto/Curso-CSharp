using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int VelocidadeMAxima { get; set; }
        public abstract void Acelerar(); //metodo abstrato nao tem implementação

        public abstract void Parar();    
    }
}
