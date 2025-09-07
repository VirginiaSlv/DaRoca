using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apDaRoca
{
    public class Roteiro
    {
        private List<CentroDeDistribuicao> centros;
        private List<Cliente> clientes;
        private List<Motoristas> motoristas;
        private List<Pedidos> pedidos;
        string strConn = "Data Source=regulus.cotuca.unicamp.br;Initial Catalog=BD23149;User ID=BD23149;Password=BD23149;MultipleActiveResultSets=true";

        public Roteiro()
        {
            centros = new List<CentroDeDistribuicao>();
            clientes = new List<Cliente>();
            motoristas = new List<Motoristas>();
            pedidos = new List<Pedidos>();
        }

        public List<Motoristas> Motoristas { get => motoristas; set => motoristas = value ?? new List<Motoristas>(); }

        public void AtribuirPedidos()
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();

                // Consulta os dados da tabela de centros de distribuição
                string centrosQuery = "SELECT idCentro, nome, latitude, longitude FROM DaRoca.CentroDeDistribuicao";
                using (SqlCommand command = new SqlCommand(centrosQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CentroDeDistribuicao centro = new CentroDeDistribuicao()
                            {
                                Id = reader.GetString(0),
                                Nome = reader.GetString(1),
                                X = reader.GetDouble(2),
                                Y = reader.GetDouble(3)
                            };
                            centros.Add(centro);
                        }
                    }
                }

                //Consulta os dados da tabela de motoristas
                string motoristasQuery = "SELECT idMotoristas, nome, idCentro FROM DaRoca.Motoristas";
                using (SqlCommand command = new SqlCommand(motoristasQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Motoristas motorista = new Motoristas()
                            {
                                IdMotorista = reader.GetString(0),
                                Nome = reader.GetString(1),
                                IdCentro = reader.GetString(2)
                            };
                            motoristas.Add(motorista);
                        }
                    }
                }
                // Tabela de pedidos
                string pedidosQuery = "SELECT idPedidos, idCliente, idCentro FROM DaRoca.Pedidos";
                using (SqlCommand command = new SqlCommand(pedidosQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pedidos pedido = new Pedidos()
                            {
                                IdPedidos = reader.GetString(0),
                                IdCliente = reader.GetString(1),
                                IdCentro = reader.GetString(2)
                            };
                            pedidos.Add(pedido);
                        }
                    }
                }

                // Tabela de clientes
                string queryClientes = "SELECT idCliente, nome, latitude, longitude FROM DaRoca.Clientes";
                using (SqlCommand command = new SqlCommand(queryClientes, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente()
                            {
                                IdCliente = reader.GetString(0),
                                Nome = reader.GetString(1),
                                X = reader.GetInt32(2),
                                Y = reader.GetInt32(3)
                            };
                            clientes.Add(cliente);
                        }
                    }
                }

                // Distribui os  pedidos igualmente entre motoristas do mesmo centro
                foreach (var centro in centros)
                {
                    List<Motoristas> motoristasNoCentro = new List<Motoristas>();
                    foreach (var motorista in motoristas)
                    {
                        if (motorista.IdCentro == centro.Id) //verifica a qual centro pertence o motorista 
                        {
                            motoristasNoCentro.Add(motorista);
                        }
                    }

                    if (motoristasNoCentro.Count > 0)
                    {
                        List<Pedidos> pedidosNoCentro = new List<Pedidos>();
                        foreach (var pedido in pedidos)
                        {
                            if (pedido.IdCentro == centro.Id) // verifica os pedidos pertencentes  ao centro
                            {
                                pedidosNoCentro.Add(pedido);
                            }
                        }

                        int oMotorista = 0;
                        foreach (var pedido in pedidosNoCentro) // atribui pedidos aos motoristas daquele mesmo centro
                        {
                            motoristasNoCentro[oMotorista].Pedidos.Add(pedido);
                            oMotorista = (oMotorista + 1) % motoristasNoCentro.Count;
                        }
                    }

                }

            }
        }
        public void GerarRotas()
        {
            foreach (var motorista in motoristas)
            {
                if (motorista.Pedidos.Count > 0)
                {
                    CentroDeDistribuicao centro = null;
                    foreach (var c in centros)
                    {
                        if (c.Id == motorista.IdCentro)
                        {
                            centro = c;
                            break;
                        }
                    }

                    if (centro != null)
                    {
                        // Calcula a  rota com o método do vizinho mais próximo
                        var rota = CalcularRota(motorista, centro);
                        foreach (var pedido in rota)
                        {
                            Cliente clienteEncontrado = null;
                            foreach (var cliente in clientes)
                            {
                                if (cliente.IdCliente == pedido.IdCliente)
                                {
                                    clienteEncontrado = cliente;
                                    break;
                                }
                            }

                            if (clienteEncontrado != null)
                            {
                                // Adicionar viagem até o cliente
                                motorista.Rota.Add($"Destino > Cliente: {clienteEncontrado.Nome}");
                            }
                        }
                    }
                }
            }
        }

        private List<Pedidos> CalcularRota(Motoristas motorista, CentroDeDistribuicao centro)
        {
            List<Pedidos> rota = new List<Pedidos>();
            List<Pedidos> pedidosNaoEntregues = new List<Pedidos>(motorista.Pedidos);

            Pedidos pedidoAtual = pedidosNaoEntregues[0];
            rota.Add(pedidoAtual);
            pedidosNaoEntregues.Remove(pedidoAtual);

            while (pedidosNaoEntregues.Count > 0)
            {
                Pedidos proximoPedido = pedidosNaoEntregues.OrderBy(p => CalcularDistancia(pedidoAtual, p)).First();
                rota.Add(proximoPedido);
                pedidosNaoEntregues.Remove(proximoPedido);
                pedidoAtual = proximoPedido;
            }

            return rota;
        }

        private double CalcularDistancia(Pedidos pedido1, Pedidos pedido2)
        {
            Cliente cliente1 = null;
            Cliente cliente2 = null;

            // Encontrar o primeiro cliente
            foreach (var cliente in clientes)
            {
                if (cliente.IdCliente == pedido1.IdCliente)
                {
                    cliente1 = cliente;
                    break;
                }
            }

            // Encontrar outro cliente
            foreach (var cliente in clientes)
            {
                if (cliente.IdCliente == pedido2.IdCliente)
                {
                    cliente2 = cliente;
                    break;
                }
            }

            // Calcular distância
            if (cliente1 != null && cliente2 != null)
            {
                double X = cliente1.X - cliente2.X;
                double Y = cliente1.Y - cliente2.Y;
                return Math.Sqrt(X * X + Y * Y);
            }

            return double.MaxValue;
        }
    }
}
