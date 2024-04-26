namespace rm551478.Models
{
    public class Prato
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
