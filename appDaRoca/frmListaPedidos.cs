using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDaRoca
{
    public partial class frmListaPedidos : Form
    {
        public string strConex;
        private DateTime dataSelecionada;
        private string centroId;

        // Construtor padrão
        public frmListaPedidos()
        {
            InitializeComponent();
            strConex = "Data Source=DESKTOP-ON8TLJP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";
        }

        // Novo construtor que aceita dois parâmetros
        public frmListaPedidos(DateTime dataSelecionada, string centroId) : this()
        {
            this.dataSelecionada = dataSelecionada;
            this.centroId = centroId;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmListaPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD23149DataSet.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
           // this.pedidosTableAdapter.Fill(this.bD23149DataSet.Pedidos);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Pedidos'. Você pode movê-la ou removê-la conforme necessário
            try
            {
                using (SqlConnection connection = new SqlConnection(strConex))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DaRoca.Pedidos", connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgvLista.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnGerarRota_Click(object sender, EventArgs e)
        {
            frmRota frmRota = new frmRota(dataSelecionada, centroId);
            frmRota.Show();
        }

        private void frmNovaProgramacao_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=regulus.cotuca.unicamp.br;Initial Catalog=BD23149;User ID=BD23149;Password=BD23149";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DaRoca.Pedidos", connection);
                    SqlDataReader dataReader = command.ExecuteReader();



                    while (dataReader.Read())
                    {
                        int idPedidos = dataReader.GetInt32(0);
                        int idCentro = dataReader.GetInt32(1);
                        string idCliente = dataReader.GetString(0);
                        string horaFeito = dataReader.GetString(1);
                        string dataEStimada = dataReader.GetString(2);
                        string status = dataReader.GetString(3);
                        //colocar no dataGridView

                    }

                    connection.Close();
                    dataReader.Close();
                }
            }

            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados" + erro); //  \(0-0)/
            }
        }

        private void txtPesquisarPedidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisarPedidos_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisarPedidos.Clear();
        }

        private void btnPesquisarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConex))
                {
                    connection.Open();

                    String id = txtPesquisarPedidos.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DaRoca.Pedidos where idPedidos = '" + id + "'", connection); // >:p

                    if (id == "")
                    {
                        adapter = new SqlDataAdapter("SELECT * FROM DaRoca.Pedidos", connection); //O_O
                    }

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgvLista.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}

