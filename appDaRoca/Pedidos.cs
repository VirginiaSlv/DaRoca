using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apDaRoca
{
    public class Pedidos 
    {
        private string idPedidos;
        private string horaFeito;
        private string dataEstimada;
        private string status;
        private string idCliente;
        private string idCentro;

        public Pedidos()
        {
        }

        public Pedidos(string idPedidos, string horaFeito, string dataEstimada, string status,string idCliente,string idCentro)
        {
            this.idPedidos = idPedidos;
            this.horaFeito = horaFeito;
            this.dataEstimada = dataEstimada;
            this.status = status;
            this.idCliente = idCliente;
            this.idCentro = idCentro;
        }

        public string IdPedidos { get => idPedidos; set => idPedidos = value; }
        public string HoraFeito { get => horaFeito; set => horaFeito = value; }
        public string DataEstimada { get => dataEstimada; set => dataEstimada = value; }
        public string Status { get => status; set => status = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdCentro { get => idCentro; set => idCentro = value; }
    }
}
