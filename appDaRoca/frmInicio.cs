using apDaRoca;
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
using static appDaRoca.frmProgramacao;

namespace appDaRoca
{
    public partial class frmInicio : Form
    {
        
        public string strConexao;

        public frmInicio()
        {
            InitializeComponent();
            strConexao = "Data Source=DESKTOP-ON8TLJP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovaProg_Click(object sender, EventArgs e)
        {
            frmProgramacao telaProg = new frmProgramacao();
            telaProg.ShowDialog();
            LoadHistorico();//Elisa: N sei se ta certo, qlqr coisa, apagar
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
        }



        private void FrmInicio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD23149DataSet.CentroDeDistribuicao'. Você pode movê-la ou removê-la conforme necessário.
            //  this.centroDeDistribuicaoTableAdapter.Fill(this.bD23149DataSet.CentroDeDistribuicao);
            // TODO: esta linha de código carrega dados na tabela 'bD23149DataSet.Pedidos'. Você pode movê-la ou removê-la conforme necessário.
            /*this.pedidosTableAdapter.Fill(this.bD23149DataSet.Pedidos);*/
            // TODO: esta linha de código carrega dados na tabela 'bD23149DataSet1.CentroDeDistribuicao'. Você pode movê-la ou removê-la conforme necessário.
            /*
            if(dataSelec.Selections.Count > 0){ 
                try
                {
                    using (SqlConnection connection = new SqlConnection(strConexao))
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT c.cidade, p.dataEstimada FROM DaRoca.CentroDeDistribuicao c JOIN DaRoca.Pedidos p ON c.idCentro = p.idCentro;", connection); //Selecionar colona: ta dando erro

                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);


                        dgvHistorico.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }*/
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio telaInicial = new frmInicio();
            telaInicial.Show();
        }

        public void LoadHistorico() //Elisa: N sei se ta certo, qlqr coisa, apagar
        {
            DataTable HistoricoTable = new DataTable();
            HistoricoTable.Columns.Add("Data", typeof(string));
            HistoricoTable.Columns.Add("Centro", typeof(string));

            foreach (var item in dataSelec.Selections)
            {
                HistoricoTable.Rows.Add(item.Data.ToString("dd/MM/yyyy"), item.Centro);
            }
            dgvHistorico.DataSource = HistoricoTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMotoristas telaMoto = new frmMotoristas();
            telaMoto.Show();
        }

        private void centrosDeDistribuiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentroDeDistribuicao telaCentro = new frmCentroDeDistribuicao();
            telaCentro.Show();
        }
    }
}
