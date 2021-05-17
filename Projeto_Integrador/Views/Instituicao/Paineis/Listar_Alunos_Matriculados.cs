using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    public partial class Listar_Alunos_Matriculados : MaterialSkin.Controls.MaterialForm
    {
        private Models.Instituicao instituicaoLogada;

        private int alunoID;
        private string nomeAluno;
        private string nomeResponsavel;
        private string curso;

        public Listar_Alunos_Matriculados(Models.Instituicao instituicaoLogada)
        {
            InitializeComponent();
            this.instituicaoLogada = instituicaoLogada;
            this.preencherLista();
        }

        private void preencherLista()
        {
            Controllers.InstituicaoController controller = new Controllers.InstituicaoController();
            controller.listaAlunosMatriculados(dataGridView1, instituicaoLogada.Id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.alunoID = Convert.ToInt32(row.Cells[0].Value);
                this.nomeAluno = row.Cells[1].Value.ToString();
                this.nomeResponsavel = row.Cells[2].Value.ToString();
                this.curso = row.Cells[3].Value.ToString();
            }

            lbl_aluno_selecionado.Text = this.alunoID.ToString();

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_detalhes_Click(object sender, EventArgs e)
        {
            Detalhes_Aluno detalhesAluno = new Detalhes_Aluno(this.alunoID);
            detalhesAluno.ShowDialog();
        }
    }
}
