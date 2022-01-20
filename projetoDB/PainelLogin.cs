using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace projetoDB
{
    public partial class PainelLogin : Form
    {

        public PainelLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (login.Text.Equals(""))
            {
                MessageBox.Show("Campo de login vazio !");
                return;
            }

            if (senha.Text.Equals(""))
            {
                MessageBox.Show("Campo de Senha vazio !");
                return;
            }

            try
            {
                MySqlConnection mySQL = Program.pegarMySQL();
                mySQL.Open();

                // Pega os usuarios com usuario/email e senha correspondentes.
                string verificar = "SELECT COUNT(*) FROM usuarios WHERE login='" + login.Text + "' AND senha='" + senha.Text + "' OR email='" + login.Text + "' AND senha='" + senha.Text + "'";
                MySqlCommand comando = new MySqlCommand(verificar, mySQL);

                DataTable tabela = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(tabela);

                foreach (DataRow atual in tabela.Rows)
                {

                    if (Convert.ToInt32(atual.ItemArray[0]) > 0)
                    {

                        this.Visible = false;

                        MessageBox.Show("Usuário conectado!");
                        PainelADM logado = new PainelADM();
                        logado.Show();

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado!");
                        break;
                    }
                }
                mySQL.Close();

            }

            catch
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            //botão para chamar a form de cadastro
            //instanciando o objeto para poder fazer o codigo de chamar a form
            PainelCadastro cadastro = new PainelCadastro();
            cadastro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //botão para poder encessar o processo e sair  do aplicativo
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
