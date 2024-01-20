using MySql.Data.MySqlClient;
using System.Data;

namespace WinF_CRUD_MySql
{
    public partial class Form1 : Form
    {

        MySqlCommand comando;
        MySqlDataAdapter dataAdapter;
        MySqlDataReader dataReader;
        string sql;
        string connectionString = "Server=localhost;Database=new_schema;User ID=root;Password=victor94875074;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string nome = textBoxNome.Text;
                    string sobrenome = textBoxSobrenome.Text;
                    string cpf = textBoxCPF.Text;
                    string query = "insert into cadastro_clientes (NOME, SOBRENOME, CPF) VALUES(@VALUE1, @VALUE2, @VALUE3)";
                    Console.WriteLine("Conexão bem-sucedida!");
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@VALUE1", nome);
                    command.Parameters.AddWithValue("@VALUE2", sobrenome);
                    command.Parameters.AddWithValue("@VALUE3", cpf);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string id = textBoxId.Text;
                    string nome = textBoxNome.Text;
                    string sobrenome = textBoxSobrenome.Text;
                    string cpf = textBoxCPF.Text;
                    string query = "update cadastro_clientes  set NOME = @VALUE1, SOBRENOME=@VALUE2, CPF=@VALUE3 WHERE ID = @ID";
                    MessageBox.Show("Conexão estabelecida com banco de dados!");
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@VALUE1", nome);
                    command.Parameters.AddWithValue("@VALUE2", sobrenome);
                    command.Parameters.AddWithValue("@VALUE3", cpf);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string nome = textBoxNome.Text;
                    string sobrenome = textBoxSobrenome.Text;
                    string cpf = textBoxCPF.Text;
                    string query = "select * from cadastro_clientes";
                    MessageBox.Show("Conexão estabelecida com banco de dados!");
                    dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable tabela = new DataTable();
                    dataAdapter.Fill(tabela);
                    dataGridView1.DataSource = tabela;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
        }
    }
}
