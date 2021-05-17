using System;

namespace Projeto_Integrador.Views.Instituicao
{
    public partial class Cadastro_Instituicao : MaterialSkin.Controls.MaterialForm
    {
        public Cadastro_Instituicao()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finaliza_cadastro_Click(object sender, EventArgs e)
        {
            Models.Instituicao novaInstituicao = new Models.Instituicao();

            novaInstituicao.Nome = txb_nome.Text;
            novaInstituicao.CNPJ1 = txb_CNPJ.Text;
            novaInstituicao.Email = txb_email.Text;
            novaInstituicao.Telefone = txb_telefone.Text;
            novaInstituicao.Endereco = txb_endereco.Text;
            novaInstituicao.Login = txb_usuario.Text;
            novaInstituicao.Senha = txb_senha.Text;

            novaInstituicao.cadastraInstituicao();

            this.Close();
        }
    }
}
