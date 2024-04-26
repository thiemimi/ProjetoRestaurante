namespace rm551478.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }
    }
}
