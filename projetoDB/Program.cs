using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loadin());

            criarTabela();
        }

        private static string conexao = "SERVER=localhost;port=3306;User id=root;database=trovao;password=;";

        public static MySqlConnection pegarMySQL()
        {
            MySqlConnection mySQL = null;

            try
            {
                // Prepara para abrir a conexão com o MySQL.
                mySQL = new MySqlConnection(conexao);
            }
            catch (Exception erro)
            {
                Console.WriteLine(" Erro ao conectar ao MySQL: " + erro.Message);
            }

            return mySQL;
        }

        static void criarTabela()
        {

            MySqlConnection mySQL = pegarMySQL();


            // Tenta abrir a conexão com o MySQL
            mySQL.Open();

            // Cria uma tabela no MySQL com o nome 'usuarios' caso não exista
            MySqlCommand comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS usuarios (`login` TEXT NOT NULL, `senha` TEXT NOT NULL, `email` TEXT NOT NULL);", mySQL);
            // Tenta inserir o comando acima
            comando.ExecuteNonQuery();
            comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes (`NOME` TEXT NOT NULL, `EMAIL` TEXT NOT NULL,`ENDERECO` TEXT NOT NULL,`RG` TEXT NOT NULL,`CPF` TEXT NOT NULL,`CEP` TEXT NOT NULL,`NUMERO` TEXT NOT NULL,`DATANASCIMENTO` TEXT NOT NULL);", mySQL);
            comando.ExecuteNonQuery();
            mySQL.Close();
        }
    }
}
