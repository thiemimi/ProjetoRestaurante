namespace rm551478.Models
{
    public class Funcionário(string nome, string senha, string telefone) : Usuario(nome, senha, telefone)
    {
        public int Id { get; set; }

        public override void Logar()
        {
            base.Logar();

            throw new NotImplementedException();
        }
    }
}
