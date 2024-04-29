using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rm551478.Models
{
    [Table("TB_Cliente_551478")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Column("Email", TypeName = "varchar(250)")]
        [EmailAddress]
        public string Email { get; set; }

        public string Telefone { get; set; }

        [MaxLength(11, ErrorMessage = "O CPF deve conter no máximo 11 dígitos")]
        public string CPF { get; set; }

        [StringLength(8, ErrorMessage = "O CEP deve conter 8 dígitos")]
        public string CEP { get; set; }
    }
}
