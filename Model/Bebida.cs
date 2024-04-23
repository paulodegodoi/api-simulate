namespace PizzariaCSharp.Model
{
    public class Bebida
    {
        public int BebidaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public override string ToString()
        {
            return $"Bebida: {Nome}. Preço: {Valor}";
        }
    }
}