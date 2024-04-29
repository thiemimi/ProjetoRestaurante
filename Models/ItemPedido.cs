using Humanizer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rm551478.Models
{
    [Table("TB_ItemPedido_551478")]
    public class ItemPedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemPedidoId { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int PratoId { get; set; }

        [MaxLength(2, ErrorMessage = "Não é possível pedir mais itens")]
        public int Quantidade { get; set; }

        [Column("PrecoUnitario", TypeName = "decimal(4,2)")]
        public decimal PrecoUnitario { get; set; }
    }
}

