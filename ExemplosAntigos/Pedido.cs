namespace rm551478.ExemplosAntigos
{
    public class Pedido
    {
        public int Id { get; set; }

        private static List<ItemPedido> pedidos = new List<ItemPedido>();

        internal static void AdicionarPedido(ItemPedido itemPedido)
        {
            pedidos.Add(itemPedido);
        }

        internal static void RemoverPedido(ItemPedido itemPedido)
        {
            pedidos.Remove(itemPedido);
        }

    }
}
