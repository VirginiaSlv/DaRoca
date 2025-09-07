using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apDaRoca
{
    public class Usuario : IComparable<Usuario>
    {
        private string idNome;
        private string senha;

        public Usuario(){     }

        public string IdNome
        {
            get => idNome;
            set => idNome = value;
        }

        public string Senha 
        { 
            get => senha;
            set => senha = value; 
        }

        public int CompareTo(Usuario usuario)
        {
           return IdNome.CompareTo(usuario.IdNome);
        }

        public bool VerifLogin(string usuario,string senha)
        {
            usuario = usuario.Trim().ToLower(); 
            senha = senha.Trim();

            // Verificar se IdNome e Senha não são nulos ou vazios
            if (!string.IsNullOrEmpty(IdNome) && !string.IsNullOrEmpty(Senha))
            {
                // Normalizar os dados do objeto Usuario (IdNome e Senha)
                string idNomeNormalizado = IdNome.Trim().ToLower();
                string senhaNormalizada = Senha.Trim();

                // Comparar os dados normalizados
                if (idNomeNormalizado == usuario && senhaNormalizada == senha)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
