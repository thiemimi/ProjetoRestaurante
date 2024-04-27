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
        public int Id { get; set; }
        protected string Rua { get; set; }
        protected int Numero { get; set; }
        protected string Complemento { get; set; }
    }
}
