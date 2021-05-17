using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Usuario.Paineis
{
    public partial class Painel_Matriculas : MaterialSkin.Controls.MaterialForm
    {
        private Models.Usuario usuario;
        private int alunoSelecionadoID;
        public Painel_Matriculas(Models.Usuario usuarioLogado)
        {
            InitializeComponent();
            this.usuario = usuarioLogado;
            this.preencheDados();
        }

        private void preencheDados()
        {
            Controllers.UsuarioController usuarioController = new Controllers.UsuarioController();
            usuarioController.listarAlunosCadastrados(dataGridView1, this.usuario.Id);
        }

        private void btn_ver_detalhes_Click(object sender, EventArgs e)
        {
            Detalhes_Matricula detalhesMatricula = new Detalhes_Matricula(this.alunoSelecionadoID);
            detalhesMatricula.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.preencheDados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.alunoSelecionadoID = Convert.ToInt32(row.Cells[0].Value);
            }

            lbl_aluno_selecionado.Text = this.alunoSelecionadoID.ToString();
        }

        private void btn_remover_matricula_Click(object sender, EventArgs e)
        {
            Controllers.UsuarioController controller = new Controllers.UsuarioController();
            controller.removerMatricula(this.alunoSelecionadoID);

            this.preencheDados();
        }
    }
}
