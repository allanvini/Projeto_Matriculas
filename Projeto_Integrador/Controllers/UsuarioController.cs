using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto_Integrador.Controllers
{
    class UsuarioController
    {
        private Models.Usuario usuario;

        private MySqlConnection con;
        private Connection.Connection connection;

        public Models.Usuario logaUsuario(string usuario, string senha)
        {

            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "SELECT * FROM responsavel WHERE Login = ?usuario";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?usuario", usuario);

                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();

                if (MySqlDR.Read())
                {
                    string senhaHash = Utils.Seguranca.generateHash(senha);
                    string senhaSalt = MySqlDR.GetString(9);

                    string senhaSalted = Utils.Seguranca.generateHash($"{senhaHash}{senhaSalt}");


                    if (senhaSalted == MySqlDR.GetString(8))
                    {
                        this.usuario = new Models.Usuario(
                            Convert.ToInt32(MySqlDR.GetString(0)),
                            MySqlDR.GetString(1),
                            MySqlDR.GetString(2),
                            Convert.ToInt32(MySqlDR.GetString(3)),
                            MySqlDR.GetString(4),
                            MySqlDR.GetString(5),
                            MySqlDR.GetString(6),
                            usuario
                        );

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }

            return this.usuario;

        }

        public void cadastraUsuario(Models.Usuario novoUsuario)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "INSERT INTO responsavel (Nome, CPF, Idade, Email, Telefone, Endereco, Login, Senha, SenhaSALT) VALUES (?Nome, ?CPF, ?Idade, ?Email, ?Telefone, ?Endereco, ?Login, ?Senha, ?SenhaSALT)";

            Random salt = new Random();

            string senhaHash = Utils.Seguranca.generateHash(novoUsuario.Senha);

            string senhaSalt = Utils.Seguranca.generateHash(salt.Next(10).ToString());

            string SenhaSalted = Utils.Seguranca.generateHash($"{senhaHash}{senhaSalt}");

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?Nome", novoUsuario.Nome);
                command.Parameters.AddWithValue("?CPF", novoUsuario.CPF1);
                command.Parameters.AddWithValue("?Idade", novoUsuario.Idade);
                command.Parameters.AddWithValue("?Email", novoUsuario.Email);
                command.Parameters.AddWithValue("?Telefone", novoUsuario.Telefone);
                command.Parameters.AddWithValue("?Endereco", novoUsuario.Endereco);
                command.Parameters.AddWithValue("?Login", novoUsuario.Login);
                command.Parameters.AddWithValue("?Senha", SenhaSalted);
                command.Parameters.AddWithValue("?SenhaSALT", senhaSalt);

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
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cadastraAluno(Models.Aluno novoAluno, int instituicaoID, int responsavelID, int cursoID, float valorCurso)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "INSERT INTO aluno(Nome, Idade, Email, Telefone, Endereco, Fk_instituicao_ID, Fk_responsavel_ID, Fk_curso_ID) VALUES (?Nome, ?Idade, ?Email, ?Telefone, ?Endereco, ?Fk_instituicao_ID, ?Fk_responsavel_ID, ?Fk_curso_ID);";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?Nome", novoAluno.Nome);
                command.Parameters.AddWithValue("?Idade", novoAluno.Idade);
                command.Parameters.AddWithValue("?Email", novoAluno.Email);
                command.Parameters.AddWithValue("?Telefone", novoAluno.Telefone);
                command.Parameters.AddWithValue("?Endereco", novoAluno.Endereco);
                command.Parameters.AddWithValue("?Fk_instituicao_ID", instituicaoID);
                command.Parameters.AddWithValue("?Fk_responsavel_ID", responsavelID);
                command.Parameters.AddWithValue("?Fk_curso_ID", cursoID);

                command.ExecuteNonQuery();
                command.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();

                try
                {
                    con.Open();

                    int alunoID;

                    string queryGetID = "SELECT MAX(ID) FROM aluno";

                    MySqlCommand command2 = new MySqlCommand(queryGetID, con);

                    command2.Parameters.AddWithValue("?responsavelID", responsavelID);

                    MySqlDataReader MySqlDR = command2.ExecuteReader();
                    MySqlDR.Read();

                    alunoID = Convert.ToInt32(MySqlDR.GetString(0));

                    this.finalizaCadastroAluno(alunoID, instituicaoID, valorCurso);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Aluno matriculado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void finalizaCadastroAluno(int alunoID, int instituicaoID, float valorDivida)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "INSERT INTO solicitacao_pagamento (Fk_aluno_ID, Fk_instituicao_ID, Valor_divida) VALUES (?Fk_aluno_ID, ?Fk_instituicao_ID, ?Valor_divida);";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?Fk_aluno_ID", alunoID);
                command.Parameters.AddWithValue("?Fk_instituicao_ID", instituicaoID);
                command.Parameters.AddWithValue("?Valor_divida", valorDivida);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

                con.Close();
            }
        }

        public void listarAlunosCadastrados(DataGridView dtgv, int responsavelID)
        {
            connection = new Connection.Connection();
            dtgv.DataSource = null;
            dtgv.Rows.Clear();
            dtgv.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT " +
                                "aluno.ID, " +
                                "aluno.Nome, " +
                                "instituicao.Nome, " +
                                "responsavel.Nome, " +
                                "curso.Nome " +
                           "FROM aluno " +
                                "INNER JOIN instituicao ON instituicao.ID = aluno.Fk_instituicao_ID " +
                                "INNER JOIN responsavel ON responsavel.ID = aluno.Fk_responsavel_ID " +
                                "INNER JOIN curso ON curso.ID = aluno.Fk_curso_ID " +
                           "WHERE aluno.Fk_responsavel_ID = ?ResponsavelID;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?ResponsavelID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?ResponsavelID"].Value = responsavelID;

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
                                dataTable.Rows[index][4]
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

        public void listarInstituicoesDisponiveis(DataGridView dtgv)
        {
            connection = new Connection.Connection();
            dtgv.DataSource = null;
            dtgv.Rows.Clear();
            dtgv.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT ID, Nome, Telefone, Email, Endereco FROM instituicao;";

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
                                dataTable.Rows[index][2],
                                dataTable.Rows[index][3],
                                dataTable.Rows[index][4]
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

        public void removerMatricula(int alunoID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "DELETE FROM solicitacao_pagamento WHERE Fk_aluno_ID = ?AlunoID2; " +
                           "DELETE FROM parcelas WHERE Fk_aluno_ID = ?AlunoID3; " +
                           "DELETE FROM aluno WHERE ID = ?AlunoID; ";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?AlunoID", alunoID);
                command.Parameters.AddWithValue("?AlunoID2", alunoID);
                command.Parameters.AddWithValue("?AlunoID3", alunoID);

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
                MessageBox.Show("Matricula removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
