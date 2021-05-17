
namespace Projeto_Integrador.Models
{
    public class Instituicao
    {
        private int id;
        private string nome;
        private string CNPJ;
        private string email;
        private string telefone;
        private string endereco;
        private string login;
        private string senha;
        private string senhaSalt;

        public Instituicao(int ID, string nome, string cnpj, string email, string telefone, string endereco)
        {
            this.id = ID;
            this.nome = nome;
            this.CNPJ = cnpj;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public Instituicao()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CNPJ1 { get => CNPJ; set => CNPJ = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string SenhaSalt { get => senhaSalt; set => senhaSalt = value; }



        public void cadastraInstituicao()
        {
            Controllers.InstituicaoController controller = new Controllers.InstituicaoController();
            controller.cadastraInstituicao(this);
        }

    }
}
