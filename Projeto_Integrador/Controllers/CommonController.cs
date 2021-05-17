using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Integrador.Controllers
{
    class CommonController
    {
        private MySqlConnection con;
        private Connection.Connection connection;

        public void consultaCursos(DataGridView dtgv)
        {
            connection = new Connection.Connection();
            dtgv.DataSource = null;
            dtgv.Rows.Clear();
            dtgv.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT * FROM curso;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2]
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }

        }

        public void listarParcelasPagas(DataGridView dtgv, int alunoID)
        {
            connection = new Connection.Connection();
            dtgv.DataSource = null;
            dtgv.Rows.Clear();
            dtgv.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT " +
                                "parcelas.ID, " +
                                "aluno.Nome, " +
                                "parcelas.Numero_parcela, " +
                                "parcelas.Valor_parcela, " +
                                "parcelas.Forma_pagamento, " +
                                "parcelas.Situacao " +
                           "FROM parcelas " +
                                "INNER JOIN aluno ON parcelas.Fk_aluno_ID = aluno.ID " +
                           "WHERE parcelas.Situacao = 'Pago' AND parcelas.Fk_aluno_ID = ?AlunoID;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);

                    command.Parameters.Add("?AlunoID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?AlunoID"].Value = alunoID;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4],
                                dataTable.Rows[index][5]
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        public void listarParcelasPendentes(DataGridView dtgv, int alunoID)
        {
            connection = new Connection.Connection();
            dtgv.DataSource = null;
            dtgv.Rows.Clear();
            dtgv.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT " +
                                "parcelas.ID, " +
                                "aluno.Nome, " +
                                "parcelas.Numero_parcela, " +
                                "parcelas.Valor_parcela, " +
                                "parcelas.Forma_pagamento, " +
                                "parcelas.Situacao " +
                           "FROM parcelas " +
                                "INNER JOIN aluno ON parcelas.Fk_aluno_ID = aluno.ID " +
                           "WHERE parcelas.Situacao = 'Pendente' AND parcelas.Fk_aluno_ID = ?AlunoID;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?AlunoID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?AlunoID"].Value = alunoID;

                    adapter.SelectCommand = command;
                    adapter.InsertCommand = command;

                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        for (int index = 0; index < dataTable.Rows.Count; index++)
                        {
                            dtgv.Rows.Add
                            (
                                dataTable.Rows[index][0],
                                dataTable.Rows[index][1],
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4],
                                dataTable.Rows[index][5]
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }
                }
            }
        }

        public Models.Aluno pegaDadosAluno(int alunoID)
        {
            Models.Aluno aluno = new Models.Aluno();

            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "SELECT ID, nome, idade, email, telefone, endereco FROM aluno WHERE aluno.ID = ?alunoID";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?alunoID", alunoID);

                MySqlDataReader MySqlDR = command.ExecuteReader();

                MySqlDR.Read();

                aluno.Id = MySqlDR.GetInt32(0);
                aluno.Nome = MySqlDR.GetString(1);
                aluno.Idade = MySqlDR.GetInt32(2);
                aluno.Email = MySqlDR.GetString(3);
                aluno.Telefone = MySqlDR.GetString(4);
                aluno.Endereco = MySqlDR.GetString(5);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }

            return aluno;
        }

        public void atualizaDadosAluno(Models.Aluno aluno)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "UPDATE aluno SET Nome = ?aluno.Nome, Idade = ?aluno.Idade, Email = ?aluno.Email, Telefone = ?aluno.Telefone, Endereco = ?aluno.Endereco WHERE aluno.ID = ?aluno.ID;";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?aluno.Nome", aluno.Nome);
                command.Parameters.AddWithValue("?aluno.Idade", aluno.Idade);
                command.Parameters.AddWithValue("?aluno.Email", aluno.Email);
                command.Parameters.AddWithValue("?aluno.Telefone", aluno.Telefone);
                command.Parameters.AddWithValue("?aluno.Endereco", aluno.Endereco);
                command.Parameters.AddWithValue("?aluno.ID", aluno.Id);

                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Aluno editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void pagaParcela(int parcelaID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "UPDATE parcelas SET Situacao = 'Pago' WHERE parcelas.ID = ?parcelaID;";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?parcelaID", parcelaID);

                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
                MessageBox.Show("Pagamento registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
