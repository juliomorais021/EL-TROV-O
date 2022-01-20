using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace projetoDB
{
    public partial class PainelADM : Form
    {
        public PainelADM()
        {
            InitializeComponent();
        }
        private void  buscarusuariosPornome(){

        }
        private void buscarClientes()
        {
            try
            {
                //listagem de todos os usuarios no  DB
                MySqlConnection mySQL = Program.pegarMySQL();
                mySQL.Open();
                // comandobuscar = ordem para o banco de dados selecionar a tabela usuario e listar todos os dados que estão lá
                string comandobuscar = "SELECT * FROM clientes";
                // executando = variavel que vai receber o comando  propriamente dito + a string  de conexão 
                MySqlCommand executando = new MySqlCommand(comandobuscar,mySQL);
                // DA RESPONSAVEL  POR RECEBER  OS DADOS CONSUTADOS NO BANDO DE DADOS OBS: SÓ É UTILIZADO  QUANDO  TEMOS QUE BUSCAR DADOS E LISTALOS
                MySqlDataAdapter DA = new MySqlDataAdapter(executando);
                DataTable dt = new DataTable();
                //COLOCANDO  OS DADOS RETORNADOS EM  UMA TABELA PARA LISTALOS NA DATAGRID
                DA.Fill(dt);
                dataGridView1.DataSource = dt; 
       
            }
            catch 
            {
                MessageBox.Show("ERRO AO  BUSCAR USUARIO !");
            }

        }

        private void PainelADM_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deletar_Click(object sender, EventArgs e)
        {
            if (usuario.Equals(""))
            {
                MessageBox.Show("Usuário inválido!");
                return;
            }

            try
            {
                MySqlConnection mySQL = Program.pegarMySQL();
                mySQL.Open();


                string verificar = "SELECT COUNT(*) FROM usuarios WHERE login='" + usuario.Text + "' OR email='" + usuario.Text + "'";
                
                MySqlCommand comando = new MySqlCommand(verificar, mySQL);

                DataTable tabela = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(tabela);

                foreach (DataRow atual in tabela.Rows)
                {

                    if (Convert.ToInt32(atual.ItemArray[0]) > 0)
                    {
                        MessageBox.Show("Usuário deletado com sucesso!");

                        /*tabela.AcceptChanges();
                        atual.Delete();
                        tabela.AcceptChanges();
                        
                        vai se fuder julio, faz isso funcionar,  n ta deletando o código de cima*/

                        comando = new MySqlCommand("DELETE FROM usuarios WHERE login='" + usuario.Text + "' OR email='" + usuario.Text + "'", mySQL);
                        comando.ExecuteNonQuery();

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

        private void deletarTudo_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySQL = Program.pegarMySQL();
                mySQL.Open();
              

                MySqlCommand comando = new MySqlCommand("TRUNCATE clientes", mySQL);
                comando.ExecuteNonQuery();

                MessageBox.Show("Você deletou todos os usuários!");

                mySQL.Close();

            }
            catch
            {

            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            PainelLogin login = new PainelLogin();
            login.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buscarusuario_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            buscarClientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            NovoUS inci = new  NovoUS();
            inci.Show();
           
        }
    }
}
