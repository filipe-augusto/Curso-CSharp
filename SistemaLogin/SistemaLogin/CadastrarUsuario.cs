using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaLogin
{
   static class CadastrarUsuario
    {

        /*
         * 
         * Um membro estático não pode ser referenciado através de uma instância mas somente através do nome do tipo.
         * RESUMO:
  - Não pode ser usada com indexadores;
  - Pode ser usada em construtores;
  - Por padrão é privada;
  - Pode ser publica ou parametrizada;
  - Se aplicada a uma classe todos os membros tem que ser estáticos também;
  - Não pode ser acessado por uma instância;*/
        private static Usuario[] usuarios =
            {
                new Usuario(){ Nome = "Filipe",Senha="abc123"},//0
                new Usuario(){ Nome = "fabio",Senha="abc12345"},//1
                new Usuario(){ Nome = "Arthur",Senha="bb"}//2
        };
        private static Usuario _userLogado = null;
      
        public static Usuario UsuarioLogado {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)  {
            foreach(Usuario usuario in usuarios) {
                if (usuario.Nome == nome && usuario.Senha == senha) {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
                return false;
        }
    }
}
