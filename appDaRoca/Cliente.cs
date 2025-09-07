using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apDaRoca
{
    public class Cliente
    {
        private string idCliente;
        private string nome;
        private string cidade;
        private string estado;
        private double x;
        private double y;

        public Cliente()
        {
        }

        public Cliente(string idCleiente, string nome, string cidade, string estado, double x, double y)
        {
            this.idCliente = idCleiente;
            this.nome = nome;
            this.cidade = cidade;
            this.estado = estado;
            this.x = x;
            this.y = y;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }  
    }
}
