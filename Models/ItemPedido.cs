namespace Atividade6_Blazor.Models
{
    public class ItemPedido
    {
        public int Id { get; set;}
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Produto.Preco * Quantidade;
    }
}
