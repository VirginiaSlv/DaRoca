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

namespace appDaRoca
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            try
            {
                bool loginSucesso = false;

                foreach (Usuario usuarioDB in usuarios)
                {
                    if (usuarioDB.VerifLogin(usuario, senha))
                    {
                        loginSucesso = true;
                        break;
                    }
                }

                if (loginSucesso)
                {
                    MessageBox.Show("Seja bem-vindo!");
                    frmInicio telaInicio = new frmInicio();
                    telaInicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar fazer login: " + ex.Message);
            }

        }

        private List<Usuario> usuarios = new List<Usuario>();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-ON8TLJP\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DaRoca.Usuarios", connection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    // Limpar a lista de usuários antes de adicionar novos
                    usuarios.Clear();

                    while (dataReader.Read())
                    {
                        string id = dataReader.GetString(0);
                        string senha = dataReader.GetString(1);

                        // Criar um novo objeto Usuario e atribuir os valores do banco de dados
                        Usuario usuario = new Usuario();
                        usuario.IdNome = id;
                        usuario.Senha = senha;

                        // Adicionar o usuário à lista
                        usuarios.Add(usuario);
                    }

                    connection.Close();
                    dataReader.Close();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados: " + erro.Message);
            }
        }
    }
}
