using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySqlConnector;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDB
{
    public partial class NovoUS : Form
    {

        private void cadastrandousuario()
        {
           
            try
            {
                // comando = new MySqlCommand("INSERT INTO usuarios (login, senha, email) VALUES ('" + login.Text + "', '" + senha.Text + "', '" + email.Text + "');", mySQL);

                string introduzir = "INSERT INTO clientes(NOME,EMAIL,ENDERECO,RG,CPF,CEP,NUMERO,DATANASCIMENTO) VALUES ('"+nometxt.Text+"','"+emailtxt.Text+"','"+enderecotxt.Text+"','"+rgtxt.Text+"','"+cpftxt.Text+"','"+ceptxt.Text+"','"+numerotxt.Text+"','"+datatxt.Text+"')";
                MySqlConnection msql = Program.pegarMySQL();
                msql.Open();
                MySqlCommand tt = new MySqlCommand(introduzir, msql);
                tt.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado!");
                msql.Close();

            }
            catch(Exception erro)
            {

                MessageBox.Show("erro ao cadastrar !" + erro.Message);
            }

        }
        public NovoUS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            cadastrandousuario();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void NovoUS_Load(object sender, EventArgs e)
        {

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime data = monthCalendar1.SelectionRange.Start.ToLocalTime();

            int day = data.Day + 1;

            string dia = day < 10 ? "0" + day : day + "";
            string mes = data.Month < 10 ? "0" + data.Month : data.Month + "";
            string ano = data.Year < 10 ? "0" + data.Year : data.Year + "";

            datatxt.Text = day + "/" + mes + "/" + ano;
        }
    }
}
