namespace rm551478.Models
{
    public class Funcionário(string nome, string telefone) : Usuario(nome, telefone)
    {
        public int Id { get; set; }
    }
}
