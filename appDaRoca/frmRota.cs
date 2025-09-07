using apDaRoca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDaRoca
{
    public partial class frmRota : Form
    {
        private Roteiro roteiro;
        public DateTime DataSelecionada { get; set; }
        public string CentroId { get; set; }

        public frmRota()
        {
            InitializeComponent();
            roteiro = new Roteiro();
        }

        public frmRota(DateTime dataSelecionada, string centroId) : this()
        {
            DataSelecionada = dataSelecionada;
            CentroId = centroId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roteiro = new Roteiro();
            roteiro.AtribuirPedidos();
            roteiro.GerarRotas(); // Gera as rotas antes de exibir

            lbRotas.Items.Clear(); // Limpa a lista antes de adicionar novos itens

            foreach (var motorista in roteiro.Motoristas)
            {
                if (motorista.Pedidos.Count > 0)
                {
                    lbRotas.Items.Add($"Motorista: {motorista.Nome}");

                    foreach (var rota in motorista.Rota)
                    {
                        lbRotas.Items.Add(rota);
                    }

                    lbRotas.Items.Add("");
                }
            }

            txtData.Text = DataSelecionada.ToString("dd/MM/yyyy");
            txtCentro.Text = CentroId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicio telaInicial = new frmInicio();
            telaInicial.Show();
        }
    }
}


