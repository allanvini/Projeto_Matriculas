using System;

namespace Projeto_Integrador.Views.Instituicao.Paineis
{
    public partial class Cadastrar_Novo_Curso : MaterialSkin.Controls.MaterialForm
    {
        public Cadastrar_Novo_Curso()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Controllers.InstituicaoController controller = new Controllers.InstituicaoController();

            controller.cadastraCurso(txb_nome.Text, float.Parse(txb_valor.Text));

            this.Close();
        }
    }
}
