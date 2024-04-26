namespace rm551478.Models
{
    public class Cliente : Usuario
    {
        public int Id { get; set; }

        public required Endereco Endereco { get; set; }  
    }
}
