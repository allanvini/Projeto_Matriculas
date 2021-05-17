using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    public partial class Dashboard_Instituicao : MaterialSkin.Controls.MaterialForm
    {
        Models.Instituicao instituicaoLogada;
        public Dashboard_Instituicao(Models.Instituicao instituicaoLogada)
        {
            InitializeComponent();

            this.Text = $"Olá, {instituicaoLogada.Nome}";
            this.instituicaoLogada = instituicaoLogada;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_listar_alunos_Click(object sender, EventArgs e)
        {
            Listar_Alunos_Matriculados listaAlunos = new Listar_Alunos_Matriculados(this.instituicaoLogada);
            listaAlunos.ShowDialog();
        }

        private void btn_listar_disciplinas_Click(object sender, EventArgs e)
        {
            Listar_Disciplinas_Cadastradas listaDisciplinas = new Listar_Disciplinas_Cadastradas();
            listaDisciplinas.ShowDialog();
        }

        private void btn_listar_analises_Click(object sender, EventArgs e)
        {
            Ver_Matriculas_Pendentes listaPendencias = new Ver_Matriculas_Pendentes(instituicaoLogada.Id);
            listaPendencias.ShowDialog();
        }
    }
}
