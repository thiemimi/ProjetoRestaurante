﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rm551478.Models
{
    [Table("TB_Prato_551478")]
    public class Prato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PratoId { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

    }
}
