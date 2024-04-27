namespace rm551478.Models
{
    public class Cliente : Usuario
    {

        public Cliente(string nome, string telefone, Endereco endereco) : base(nome, telefone)
        {
            Endereco = endereco;
        }
        public int Id { get; set; }
        public new Endereco Endereco { get; }
    }
}
