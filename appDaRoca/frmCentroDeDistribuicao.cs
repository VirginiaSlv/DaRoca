using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appDaRoca
{
    public partial class frmCentroDeDistribuicao : Form
    {
        private string strConn;

        public frmCentroDeDistribuicao()
        {
            InitializeComponent();
            strConn = "Data Source=DESKTOP-ON8TLJP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";
        }

        private void frmCentroDeDistribuicao_Load(object sender, EventArgs e)
        {
            // Configurar ListBoxes para aceitar seleção múltipla
            Apoiam.SelectionMode = SelectionMode.MultiExtended;
            Apoiados.SelectionMode = SelectionMode.MultiExtended;

            LoadListBoxes();
        }

        private void LoadListBoxes()
        {
            // IDs e nomes específicos dos centros
            string[] centroIds = {
                "DDF7C88F-42E6-4DB6-9093-C99851035A13", // Campinas
                "C79B401E-BF71-4047-8362-6711886F0E8C", // São Paulo
                "3120E35F-B70B-4D99-A361-2EC15283756D"  // Ribeirão Preto
            };

            string[] centroNomes = {
                "Campinas",
                "São Paulo",
                "Ribeirão Preto"
            };

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    // Carregar os centros específicos nos ListBoxes
                    for (int i = 0; i < centroIds.Length; i++)
                    {
                        Apoiam.Items.Add(new ListItem(centroNomes[i], centroIds[i]));
                        Apoiados.Items.Add(new ListItem(centroNomes[i], centroIds[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnCompartilharCentros_Click(object sender, EventArgs e)
        {
            if (Apoiam.SelectedItems.Count > 0 && Apoiados.SelectedItems.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        foreach (ListItem item1 in Apoiam.SelectedItems)
                        {
                            foreach (ListItem item2 in Apoiados.SelectedItems)
                            {
                                string centro1Id = item1.Value;
                                string centro2Id = item2.Value;

                                if (centro1Id != centro2Id)
                                {
                                    string countQuery = "SELECT COUNT(*) FROM DaRoca.Pedidos WHERE idCentro = @Centro1Id AND status = 'Awaiting Shipment'";
                                    SqlCommand countCmd = new SqlCommand(countQuery, conn);
                                    countCmd.Parameters.AddWithValue("@Centro1Id", centro1Id);
                                    int totalPedidos = (int)countCmd.ExecuteScalar();

                                    if (totalPedidos > 0)
                                    {
                                        int pedidosPorCentro = totalPedidos / 2;

                                        string updateQuery = "UPDATE TOP (@PedidosPorCentro) DaRoca.Pedidos SET idCentro = @Centro2Id " +
                                                             "WHERE idCentro = @Centro1Id AND status = 'Awaiting Shipment'";
                                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                                        updateCmd.Parameters.AddWithValue("@PedidosPorCentro", pedidosPorCentro);
                                        updateCmd.Parameters.AddWithValue("@Centro1Id", centro1Id);
                                        updateCmd.Parameters.AddWithValue("@Centro2Id", centro2Id);
                                        updateCmd.ExecuteNonQuery();

                                        string insertQuery = "INSERT INTO DaRoca.CompartilharCentro (idCentroCompartilhar, idCentroRecebem) VALUES (@Centro1Id, @Centro2Id)";
                                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                                        insertCmd.Parameters.AddWithValue("@Centro1Id", centro1Id);
                                        insertCmd.Parameters.AddWithValue("@Centro2Id", centro2Id);
                                        insertCmd.ExecuteNonQuery();

                                        MessageBox.Show($"Serviços foram compartilhados entre os centros {item1.Text} e {item2.Text}.");
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Não há pedidos em 'Awaiting Shipment' associados ao centro {item1.Text}.");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao compartilhar serviços: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um centro em ambos os ListBoxes.");
            }
        }

        

        private void btnVoltarInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio telaInicial = new frmInicio();
            telaInicial.Show();
        }

        private void Apoiam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manipular a seleção de Apoiam, se necessário
        }

        private void Apoiados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manipular a seleção de Apoiados, se necessário
        }

        public class ListItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ListItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnDesfazerCompartilhamento_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();

                        string selectQuery = "SELECT TOP 1 idCentroCompartilhar, idCentroRecebem " +
                                             "FROM DaRoca.CompartilharCentro " +
                                             "ORDER BY idCentroCompartilhar DESC";
                        SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                        SqlDataReader reader = selectCmd.ExecuteReader();

                        string centro1Id = null;
                        string centro2Id = null;

                        if (reader.Read())
                        {
                            centro1Id = reader["idCentroCompartilhar"].ToString();
                            centro2Id = reader["idCentroRecebem"].ToString();
                        }
                        reader.Close();

                        if (!string.IsNullOrEmpty(centro1Id) && !string.IsNullOrEmpty(centro2Id))
                        {
                            string revertPedidosQuery = "UPDATE DaRoca.Pedidos SET idCentro = @Centro1Id " +
                                                        "WHERE idCentro = @Centro2Id AND status = 'Awaiting Shipment'";
                            SqlCommand revertPedidosCmd = new SqlCommand(revertPedidosQuery, conn);
                            revertPedidosCmd.Parameters.AddWithValue("@Centro1Id", centro1Id);
                            revertPedidosCmd.Parameters.AddWithValue("@Centro2Id", centro2Id);
                            revertPedidosCmd.ExecuteNonQuery();

                            string deleteLastSharingQuery = "DELETE FROM DaRoca.CompartilharCentro " +
                                                            "WHERE idCentroCompartilhar = @Centro1Id AND idCentroRecebem = @Centro2Id";
                            SqlCommand deleteLastSharingCmd = new SqlCommand(deleteLastSharingQuery, conn);
                            deleteLastSharingCmd.Parameters.AddWithValue("@Centro1Id", centro1Id);
                            deleteLastSharingCmd.Parameters.AddWithValue("@Centro2Id", centro2Id);
                            deleteLastSharingCmd.ExecuteNonQuery();

                            MessageBox.Show("Último compartilhamento desfeito com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Não há compartilhamento para desfazer.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao desfazer compartilhamento: " + ex.Message);
                }
            }
        }
    }
}
