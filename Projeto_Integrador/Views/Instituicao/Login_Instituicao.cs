using System;
using System.Windows.Forms;

namespace Projeto_Integrador.Views.Instituicao
{
    public partial class Login_Instituicao : MaterialSkin.Controls.MaterialForm
    {
        Login previousScreen;
        public Login_Instituicao(Login login)
        {
            InitializeComponent();

            this.previousScreen = login;
        }

        private void btn_cadastrar_instituicao_Click(object sender, EventArgs e)
        {
            Cadastro_Instituicao cadastroInstituicao = new Cadastro_Instituicao();
            cadastroInstituicao.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Controllers.InstituicaoController controller = new Controllers.InstituicaoController();
            Models.Instituicao instituicao = controller.logaInstituicao(txb_login.Text, txb_senha.Text);

            if (instituicao != null)
            {
                this.previousScreen.Hide();
                this.Hide();

                Paineis.Dashboard_Instituicao dashboardInstituicao = new Paineis.Dashboard_Instituicao(instituicao);
                dashboardInstituicao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
