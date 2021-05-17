using System;

namespace Projeto_Integrador.Views
{
    public partial class Cadastro_Usuario : MaterialSkin.Controls.MaterialForm
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finaliza_cadastro_Click(object sender, EventArgs e)
        {
            Models.Usuario novoUsuario = new Models.Usuario();

            novoUsuario.Nome = txb_nome.Text;
            novoUsuario.CPF1 = txb_CPF.Text;
            novoUsuario.Idade = Convert.ToInt32(txb_idade.Text);
            novoUsuario.Email = txb_email.Text;
            novoUsuario.Telefone = txb_telefone.Text;
            novoUsuario.Endereco = txb_endereco.Text;
            novoUsuario.Login = txb_usuario.Text;
            novoUsuario.Senha = txb_senha.Text;

            novoUsuario.cadastraUsuario();

            this.Close();

        }
    }
}
