using System;

namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    public partial class Listar_Disciplinas_Cadastradas : MaterialSkin.Controls.MaterialForm
    {
        public Listar_Disciplinas_Cadastradas()
        {
            InitializeComponent();

            this.preencherDados();
        }

        private void preencherDados()
        {
            Controllers.CommonController controller = new Controllers.CommonController();

            controller.consultaCursos(dataGridView1);
        }

        private void btn_cadastrar_curso_Click(object sender, EventArgs e)
        {
            Cadastrar_Novo_Curso cadastraNovoCurso = new Cadastrar_Novo_Curso();
            cadastraNovoCurso.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.preencherDados();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
