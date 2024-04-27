namespace rm551478.Models
{
    public class Endereco : Auditoria
    {

        public Endereco(int Id, string Rua, int Numero, string Complemento) 
        {
            this.Id = Id;
            this.Rua = Rua;
            this.Numero = Numero;
            this.Complemento = Complemento;
        }
        protected int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
