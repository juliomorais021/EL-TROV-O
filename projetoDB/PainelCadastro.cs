using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace projetoDB
{
    public partial class PainelCadastro : Form
    {
        public PainelCadastro()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            PainelLogin voltandopainel = new PainelLogin();
            voltandopainel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            
            if (login.Text.Equals(""))
            {
                MessageBox.Show("Login inválido!");
                return;
            }

            if (senha.Text.Equals(""))
            {
                MessageBox.Show("Senha inválida!");
                return;
            }

            if (email.Text.Equals("") || !email.Text.Contains("@") || !email.Text.Contains("."))
            {
                MessageBox.Show("Email inválido!");
                return;
            }

            MySqlConnection mySQL = Program.pegarMySQL();

            // Tenta abrir a conexão com o MySQL
            mySQL.Open();


            MySqlCommand comando = new MySqlCommand("select count(*) from usuarios where login= '" + login.Text + "' OR email= '" + email.Text + "'", mySQL);

            DataTable tabelinha = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);

            da.Fill(tabelinha);

            Boolean jaCadastrado = false;

            foreach (DataRow list in tabelinha.Rows)
            {

                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    jaCadastrado = true;
                    break;
                }
                else
                {
                    jaCadastrado = false;
                    break;
                }
            }

            if (jaCadastrado)
            {
                MessageBox.Show("O nome de usuário ou email já foi cadastrado!");
                return;
            }

            comando = new MySqlCommand("INSERT INTO usuarios (login, senha, email) VALUES ('" + login.Text + "', '" + senha.Text + "', '" + email.Text + "');", mySQL);
            comando.ExecuteNonQuery();

            MessageBox.Show("Sua conta foi cadastrada com sucesso! :)");

            // Tenta fechar a conexão com o MySQL
            mySQL.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PainelCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
