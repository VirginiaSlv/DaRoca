using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appDaRoca
{
    public partial class frmMotoristas : Form
    {
        public string strConn;

        public frmMotoristas()
        {
            InitializeComponent();
            strConn = "Data Source=DESKTOP-ON8TLJP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";
        }

        private void FrmMotoristas_Load(object sender, EventArgs e)
        {
            CarregarDadosMotoristas();
        }

        private void CarregarDadosMotoristas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DaRoca.Motoristas", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvMotoristas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnPesquisaMotorista_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    string id = txtPesquisaMotorista.Text;
                    string query = string.IsNullOrEmpty(id) ? "SELECT * FROM DaRoca.Motoristas" : $"SELECT * FROM DaRoca.Motoristas WHERE idMotoristas = '{id}'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvMotoristas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void txtPesquisaMotorista_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisaMotorista.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio telaInicial = new frmInicio();
            telaInicial.Show();
        }
    }
}
