using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rm551478.Models
{
    [Table("TB_Pedido_551478")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        [Column("Status", TypeName = "varchar(150)")]
        public string StatusPedido { get; set; }

        

    }
}
