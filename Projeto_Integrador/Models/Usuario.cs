
namespace Projeto_Integrador.Models
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string CPF;
        private int idade;
        private string email;
        private string telefone;
        private string endereco;
        private string login;
        private string senha;

        public Usuario(int id, string nome, string cpf, int idade, string email, string telefone, string endereco, string login)
        {
            this.id = id;
            this.nome = nome;
            this.CPF = cpf;
            this.idade = idade;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
            this.login = login;
        }

        public Usuario()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

        public void cadastraUsuario()
        {
            Controllers.UsuarioController controller = new Controllers.UsuarioController();
            controller.cadastraUsuario(this);
        }

    }
}
