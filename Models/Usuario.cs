namespace rm551478.Models
{
    public class Usuario : Auditoria, IUsuario
    {

        public Usuario(string nome, string telefone) 
        {
            if (nome == "")
                throw new Exception("O nome não pode ser vazio");
            Nome = nome;
            if (telefone == "")
                throw new Exception("O telefone não pode ser vazio");
            Telefone = telefone;
        }
        protected string Nome { get; set; }
        protected string? Email { get; set; }
        protected string Telefone { get; set; }
        public Endereco Endereco { get; set; }


        public string Getnome()
        {
            return Nome;
        }

        public string GetTelefone()
        {
            return Telefone;
        }

        public void Logar()
        {
            throw new NotImplementedException();
        }

        public void Deslogar()
        {
            throw new NotImplementedException();
        }
    }
}
