using System;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_usuario_Click(object sender, EventArgs e)
        {
            Views.Cadastro_Usuario cadastroUsuario = new Views.Cadastro_Usuario();
            cadastroUsuario.ShowDialog();
        }

        private void btn_usuario_login_Click(object sender, EventArgs e)
        {
            Controllers.UsuarioController controller = new Controllers.UsuarioController();
            Models.Usuario usuario = controller.logaUsuario(txb_usuario_login.Text, txb_usuario_senha.Text);

            if (usuario != null)
            {
                Views.Usuario.Paineis.Dashboard_Usuario dashboardUsuario = new Views.Usuario.Paineis.Dashboard_Usuario(usuario, this);
                dashboardUsuario.ShowDialog();
            } else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_instituicao_login_Click(object sender, EventArgs e)
        {
            Views.Instituicao.Login_Instituicao loginInstituicao = new Views.Instituicao.Login_Instituicao(this);
            loginInstituicao.ShowDialog();
        }
    }
}
