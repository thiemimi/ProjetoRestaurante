using System.ComponentModel.DataAnnotations;

namespace rm551478.ExemplosAntigos
{
    public class Usuario : Auditoria, IUsuario
    {

        public Usuario(string nome, string senha, string telefone, string email)
        {
            if (nome == "")
                throw new Exception("O nome não pode ser vazio");
            Nome = nome;
            if (senha == "")
                throw new Exception("A senha não pode ser vazia");
            Senha = senha;

            Telefone = telefone;
            Email = email;
        }
        protected string Nome { get; set; }


        [EmailAddress]
        public string Email { get; set; }
        [MinLength(6, ErrorMessage = "A sua senha deve contar mais de 5 caracteres")]
        protected string Senha { get; set; }
        public string Telefone { get; set; }


        public string Getnome()
        {
            return Nome;
        }

        public string GetSenha()
        {
            return Senha;
        }

        public virtual void Logar()
        {

            throw new NotImplementedException();
        }

        public void Deslogar()
        {
            throw new NotImplementedException();
        }
    }
}
