namespace rm551478.Models
{
    public class ItemPedido 
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal { get; set; }

        public required Prato Prato { get; set; }
    }
}
