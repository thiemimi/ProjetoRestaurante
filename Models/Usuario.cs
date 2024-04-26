namespace rm551478.Models
{
    public class Usuario : Auditoria
    {
        public required string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
