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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public static class dataSelec
{
    public static List<(DateTime Data, string Centro)> Selections { get; set; } = new List<(DateTime, string)>(); //Elisa: N sei se ta certo, qlqr coisa, apagar
}

namespace appDaRoca
{

    public partial class frmProgramacao : Form
    {

        public string strConn;
        public frmProgramacao()
        {
            InitializeComponent();
            strConn = "Data Source=DESKTOP-ON8TLJP\\SQLEXPRESS;Initial Catalog=Micheline;Integrated Security=True;";
        }

        private void frmProgramacao_Load(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();

                    // Obter datas dos pedidos
                    SqlCommand commandData = new SqlCommand("SELECT dataEstimada FROM DaRoca.Pedidos", connection);
                    SqlCommand commandCentros = new SqlCommand("SELECT idCentro FROM DaRoca.CentroDeDistribuicao", connection);

                    // Executar a primeira leitura
                    using (SqlDataReader dataReaderData = commandData.ExecuteReader())
                    {
                        cbData.Items.Clear();
                        while (dataReaderData.Read())
                        {
                            DateTime dataPedido = dataReaderData.GetDateTime(0);
                            cbData.Items.Add(dataPedido.ToString("dd/MM/yyyy"));
                        }
                    }

                    // Executar a segunda leitura
                    using (SqlDataReader dataReaderCentros = commandCentros.ExecuteReader())
                    {
                        cbCentro.Items.Clear();
                        while (dataReaderCentros.Read())
                        {
                            string id = dataReaderCentros.GetString(0);
                            cbCentro.Items.Add(id);
                        }
                    }

                    connection.Close();
                }
            }


            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados: " + erro.Message);
            }
        }   
     

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (cbData.SelectedItem == null || cbCentro.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma data e um centro de distribuição.");
                return;
            }

            // Obter a data selecionada
            DateTime dataSelecionada = DateTime.Parse(cbData.SelectedItem.ToString());

            // Obter o centro selecionado (assumindo que está armazenando como um objeto anônimo)
            string centroId = cbCentro.SelectedItem.ToString();

            //dataSelecionada.Selections.Add((dataSelecionada, centroId)); //Elisa: N sei se ta certo, qlqr coisa, apagar

            var frmInicio = Application.OpenForms.OfType<frmInicio>().FirstOrDefault(); //Elisa: N sei se ta certo, qlqr coisa, apagar
            frmInicio?.LoadHistorico(); //Elisa: N sei se ta certo, qlqr coisa, apagar

            // Criar uma instância do novo formulário e passar as informações selecionadas
            frmListaPedidos telaPedidos = new frmListaPedidos(dataSelecionada, centroId);
            telaPedidos.Show();
        }
    }
}
