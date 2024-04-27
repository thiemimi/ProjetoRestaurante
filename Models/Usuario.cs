namespace rm551478.Models
{
    public class Usuario : Auditoria, IUsuario
    {

        public Usuario(string nome, string senha, string telefone) 
        {
            if (nome == "")
                throw new Exception("O nome não pode ser vazio");
            Nome = nome;
            if (senha == "")
                throw new Exception("A senha não pode ser vazia");
            Senha = senha;

            Telefone = telefone;    
        }
        protected string Nome { get; set; }
        protected string Senha { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }


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
