using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Usuario.Paineis
{
    public partial class Dashboard_Usuario : MaterialSkin.Controls.MaterialForm
    {
        private Models.Usuario usuario;

        public Dashboard_Usuario(Models.Usuario usuarioLogado, Login login)
        {
            InitializeComponent();

            login.Hide();

            this.usuario = usuarioLogado;
            this.Text = $"Olá, {this.usuario.Nome}";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ver_matriculas_Click(object sender, EventArgs e)
        {
            Painel_Matriculas painelMatriculas = new Painel_Matriculas(this.usuario);
            painelMatriculas.ShowDialog();
        }

        private void btn_matricular_aluno_Click(object sender, EventArgs e)
        {
            Matricular_Aluno matricularAluno = new Matricular_Aluno(this.usuario);
            matricularAluno.ShowDialog();
        }
    }
}
