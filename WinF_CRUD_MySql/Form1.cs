using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace WinF_CRUD_MySql
{
    public partial class Form1 : Form
    {

        //MySqlCommand comando;
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
                    string query = "INSERT INTO cadastro_clientes (NOME, SOBRENOME, CPF) VALUES(@VALUE1, @VALUE2, @VALUE3)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@VALUE1", nome);
                    command.Parameters.AddWithValue("@VALUE2", sobrenome);
                    command.Parameters.AddWithValue("@VALUE3", cpf);

                    if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome) || string.IsNullOrWhiteSpace(cpf))
                    {
                        MessageBox.Show("Preencha todos os campos obrigatórios(*).");
                    }
                    else if (cpf.Length != 11)
                    {
                        MessageBox.Show("Digite um CPF válido com 11 digitos.");
                    }
                    else
                    {
                        if (ContemApenasLetras(nome) && ContemApenasLetras(sobrenome))
                        {
                            if (ContemApenasNumeros(cpf))
                        {
                            
                            command.ExecuteNonQuery();
                            MessageBox.Show("Dados inseridos com sucesso!");
                            LimparCaixaTexto();
                        }
                            else
                            {
                                MessageBox.Show("Campo CPF: Digite apenas numeros.");
                            }
                        }else
                        {
                            MessageBox.Show("Nome e Sobrenome: Apenas letras são permitidas aqui.");
                        }
                        
                    }

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
                    string query = "UPDATE cadastro_clientes  SET NOME = @VALUE1, SOBRENOME=@VALUE2, CPF=@VALUE3 WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@VALUE1", nome);
                    command.Parameters.AddWithValue("@VALUE2", sobrenome);
                    command.Parameters.AddWithValue("@VALUE3", cpf);

                    if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome) || string.IsNullOrWhiteSpace(cpf))
                    {
                        MessageBox.Show("Preencha todos os campos obrigatórios(*).");
                    }
                    else if (cpf.Length != 11)
                    {
                        MessageBox.Show("Digite um CPF válido com 11 digitos.");
                    }
                    else if (id.Contains(" "))
                    {
                        MessageBox.Show("Informe um id valido");
                    }
                    else if (id.Length <= 0)
                    {
                        MessageBox.Show("Informe um id valido");
                    }
                    else
                    {
                        if (ContemApenasLetras(nome) && ContemApenasLetras(sobrenome) && ContemApenasNumeros(cpf))
                            { 
                            command.ExecuteNonQuery();
                            MessageBox.Show("Dados alterados com sucesso!");
                            LimparCaixaTexto();
                    }   else
                        {
                            MessageBox.Show("Nome e Sobrenome: Apenas letras são permitidas aqui.");
                        }
                    }

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
                    string query = "SELECT * FROM cadastro_clientes";
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

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string id = textBoxId.Text;
                    string nome = textBoxNome.Text;
                    string sobrenome = textBoxSobrenome.Text;
                    string cpf = textBoxCPF.Text;
                    string query = "DELETE FROM cadastro_clientes WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    MessageBox.Show("Exclusao confirmada.");
                    command.ExecuteNonQuery();
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

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string id = textBoxId.Text;
                    string nome = textBoxNome.Text;
                    string sobrenome = textBoxSobrenome.Text;
                    string cpf = textBoxCPF.Text;
                    string query = "SELECT * FROM cadastro_clientes WHERE ID = @ID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        textBoxNome.Text = Convert.ToString(dataReader["NOME"]);
                        textBoxSobrenome.Text = Convert.ToString(dataReader["SOBRENOME"]);
                        textBoxCPF.Text = Convert.ToString(dataReader["CPF"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }   private void LimparCaixaTexto()
        {
            textBoxNome.Clear();
            textBoxSobrenome.Clear();
            textBoxCPF.Clear();

        }
        static bool ContemApenasLetras(string input)
        {
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(input, pattern);
        }
        static bool ContemApenasNumeros(string input)
        {
            string pattern = "^[1-9]+$";
            return Regex.IsMatch(input, pattern);
        }

    }
}