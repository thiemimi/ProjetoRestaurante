using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rm551478.Models
{
    [Table("TB_Clientes_551478", Schema = "2TDSPK")]
    public class Cliente : Usuario
    {

        public Cliente(string nome, string senha, string telefone, string email, Endereco endereco) : base(nome, senha, telefone, email)
        {
            Endereco = endereco;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [NotMapped]
        public new Endereco Endereco { get; set; }


    }
}
