using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rm551478.Models
{
    [Table("TB_Clientes_551478")]
    public class Cliente : Usuario
    {

        public Cliente(string nome, string senha, string telefone, Endereco endereco) : base(nome, senha, telefone)
        {
            Endereco = endereco;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public new Endereco Endereco { get; set; }


    }
}
