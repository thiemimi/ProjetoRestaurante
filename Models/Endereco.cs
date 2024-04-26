namespace rm551478.Models
{
    public class Endereco : Auditoria
    {
        public int Id { get; set; }
        public required string Rua { get; set; }
        public int Numero { get; set; }
        public required string Complemento { get; set; }
    }
}
