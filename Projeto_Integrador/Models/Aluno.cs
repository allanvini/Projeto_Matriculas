
namespace Projeto_Integrador.Models
{
    public class Aluno
    {
        private int id;
        private string nome;
        private int idade;
        private string email;
        private string telefone;
        private string endereco;
        private string instituicao;
        private string responsavel;
        private string curso;

        public Aluno(int id, string nome, int idade, string email, string telefone, string endereco, string instituicao, string responsavel, string curso)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
            this.instituicao = instituicao;
            this.responsavel = responsavel;
            this.curso = curso;
        }

        public Aluno(string nome, int idade, string email, string telefone, string endereco, string instituicao, string responsavel, string curso)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
            this.instituicao = instituicao;
            this.responsavel = responsavel;
            this.curso = curso;
        }

        public Aluno()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Instituicao { get => instituicao; set => instituicao = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string Curso { get => curso; set => curso = value; }
    }
}
