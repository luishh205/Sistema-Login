using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario (){Nome = "Gabriel", Senha = "abc123" },
            new Usuario (){Nome = "Joao", Senha = "123" },
            new Usuario (){Nome = "luis", Senha = "123" }
        };

        private static Usuario _UserLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _UserLogado; }
            private set { _UserLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
