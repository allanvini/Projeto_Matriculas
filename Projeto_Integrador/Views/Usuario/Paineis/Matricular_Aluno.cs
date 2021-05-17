using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Usuario.Paineis
{
    public partial class Matricular_Aluno : MaterialSkin.Controls.MaterialForm
    {
        private Models.Aluno novoAluno;
        private Models.Usuario usuario;

        private int idCursoSelecionado;
        private float valorCursoSelecionado;

        private int idInstituicaoSelecionada;
        
        public Matricular_Aluno(Models.Usuario usuarioLogado)
        {
            InitializeComponent();
            this.usuario = usuarioLogado;
            this.carregaInistituicoes();
            this.carregaCursos();
        }

        private void carregaInistituicoes()
        {
            Controllers.UsuarioController controller = new Controllers.UsuarioController();
            controller.listarInstituicoesDisponiveis(dtgv_instituicao);
        }

        private void carregaCursos()
        {
            Controllers.CommonController controller = new Controllers.CommonController();
            controller.consultaCursos(dtgv_curso);
        }

        private void btn_cancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finaliza_matricula_Click(object sender, EventArgs e)
        {
            this.novoAluno = new Models.Aluno();

            novoAluno.Nome = txb_nome.Text;
            novoAluno.Idade = Convert.ToInt32(txb_idade.Text);
            novoAluno.Email = txb_email.Text;
            novoAluno.Telefone = txb_telefone.Text;
            novoAluno.Endereco = txb_endereco.Text;

            Controllers.UsuarioController controller = new Controllers.UsuarioController();

            controller.cadastraAluno(this.novoAluno, idInstituicaoSelecionada, this.usuario.Id, this.idCursoSelecionado, this.valorCursoSelecionado);

            this.Close();
        }

        private void dtgv_curso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dtgv_curso.SelectedRows)
            {
                this.idCursoSelecionado = Convert.ToInt32(row.Cells[0].Value);
                this.valorCursoSelecionado = (float)row.Cells[2].Value;
                lbl_curso_valor.Text = $"{row.Cells[1].Value.ToString()} / {row.Cells[2].Value.ToString()}";
            }
        }

        private void dtgv_instituicao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dtgv_instituicao.SelectedRows)
            {
                this.idInstituicaoSelecionada = Convert.ToInt32(row.Cells[0].Value);
                lbl_instituicao.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
