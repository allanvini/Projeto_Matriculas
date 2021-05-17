using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto_Integrador.Controllers
{
    class InstituicaoController
    {
        private Models.Instituicao instituicao;

        private MySqlConnection con;
        private Connection.Connection connection;

        public Models.Instituicao logaInstituicao(string login, string senha)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "SELECT * FROM instituicao WHERE Login = ?Login";

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?Login", login);

                command.Dispose();

                MySqlDataReader MySqlDR = command.ExecuteReader();

                if (MySqlDR.Read())
                {
                    string senhaHash = Utils.Seguranca.generateHash(senha);
                    string senhaSalt = MySqlDR.GetString(8);

                    string senhaSalted = Utils.Seguranca.generateHash($"{senhaHash}{senhaSalt}");

                    if (senhaSalted == MySqlDR.GetString(7))
                    {
                        this.instituicao = new Models.Instituicao(
                                Convert.ToInt32(MySqlDR.GetString(0)),
                                MySqlDR.GetString(1),
                                MySqlDR.GetString(2),
                                MySqlDR.GetString(3),
                                MySqlDR.GetString(4),
                                MySqlDR.GetString(5)
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

            return this.instituicao;
        }

        public void cadastraInstituicao(Models.Instituicao novaInstituicao)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "INSERT INTO instituicao (Nome, CNPJ, Email, Telefone, Endereco, Login, Senha, SenhaSALT) VALUES (?Nome, ?CNPJ, ?Email, ?Telefone, ?Endereco, ?Login, ?Senha, ?SenhaSALT);";

            Random salt = new Random();

            string senhaHash = Utils.Seguranca.generateHash(novaInstituicao.Senha);
            string senhaSalt = Utils.Seguranca.generateHash(salt.Next(10).ToString());

            string SenhaSalted = Utils.Seguranca.generateHash($"{senhaHash}{senhaSalt}");

            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?Nome", novaInstituicao.Nome);
                command.Parameters.AddWithValue("?CNPJ", novaInstituicao.CNPJ1);
                command.Parameters.AddWithValue("?Email", novaInstituicao.Email);
                command.Parameters.AddWithValue("?Telefone", novaInstituicao.Telefone);
                command.Parameters.AddWithValue("?Endereco", novaInstituicao.Endereco);
                command.Parameters.AddWithValue("?Login", novaInstituicao.Login);
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
                MessageBox.Show("Instituição cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void cadastraCurso(string nomeCurso, float valorCurso)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "INSERT INTO curso (Nome, Valor) VALUES (?nomeCurso, ?valorCurso); ";

            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("?nomeCurso", nomeCurso);
                command.Parameters.AddWithValue("?valorCurso", valorCurso);

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
                MessageBox.Show("Curso cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void listaAlunosMatriculados(DataGridView dtgv, int idInstituicao)
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
                           "WHERE aluno.Fk_instituicao_ID = ?instituicaoID";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {

                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?instituicaoID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?instituicaoID"].Value = idInstituicao;

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

        public void listaMatricuasEmAnalise(DataGridView dtgv, int instituicaoID)
        {
            connection = new Connection.Connection();
            dtgv.DataSource = null;
            dtgv.Rows.Clear();
            dtgv.Refresh();

            string connectionString = connection.getConnectionString();

            string query = "SELECT " +
                                "solicitacao_pagamento.ID, " +
                                "aluno.Nome, " +
                                "instituicao.Nome, " +
                                "solicitacao_pagamento.Quantidade_parcelas, " +
                                "solicitacao_pagamento.Juros, " +
                                "solicitacao_pagamento.Valor_divida, " +
                                "solicitacao_pagamento.Situacao " +
                            "FROM solicitacao_pagamento " +
                                "INNER JOIN aluno ON aluno.ID = solicitacao_pagamento.Fk_aluno_ID " +
                                "INNER JOIN instituicao ON instituicao.ID = solicitacao_pagamento.Fk_instituicao_ID " +
                               "WHERE solicitacao_pagamento.Situacao = 'Aguardando análise' AND solicitacao_pagamento.Fk_instituicao_ID = ?instituicaoID ;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {

                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.Add("?instituicaoID", (MySqlDbType)SqlDbType.Int);
                    command.Parameters["?instituicaoID"].Value = instituicaoID;

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

        public void voltarParcela(int parcelaID)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            string query = "UPDATE parcelas SET Situacao = 'Pendente' WHERE parcelas.ID = ?parcelaID;";

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
                MessageBox.Show("Pagamento revertido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cadastrarParcelas(int numeroParcelas, double juros, double valorTotal, int alunoID, string formaPagamento)
        {
            con = new MySqlConnection();
            connection = new Connection.Connection();

            con.ConnectionString = connection.getConnectionString();

            double valorComJuros = valorTotal + ((valorTotal/100)*juros);
            double valorParcela = valorComJuros / numeroParcelas;

            string query = "INSERT INTO parcelas (Fk_aluno_ID, Numero_parcela, Valor_parcela, Forma_pagamento) VALUES (?Fk_aluno_ID, ?Numero_parcela, ?Valor_parcela, ?Forma_pagamento); UPDATE solicitacao_pagamento SET Situacao = 'Concluido' WHERE Fk_aluno_ID = ?alunoID ";

            try
            {
                for (int parcela = 1; parcela <= numeroParcelas; parcela++)
                {
                    con.Open();

                    MySqlCommand command = new MySqlCommand(query, con);

                    command.Parameters.AddWithValue("?Fk_aluno_ID", alunoID);
                    command.Parameters.AddWithValue("?Numero_parcela", parcela);
                    command.Parameters.AddWithValue("?Valor_parcela", valorParcela);
                    command.Parameters.AddWithValue("?Forma_pagamento", formaPagamento);
                    command.Parameters.AddWithValue("?alunoID", alunoID);

                    command.ExecuteNonQuery();
                    command.Dispose();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro com o banco de dados: {ex}", "Erro BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Parcelamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
