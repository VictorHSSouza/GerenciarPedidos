namespace Atividade6_Blazor.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Today;
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>(); 
        public decimal Total => Itens.Sum(item => item.Subtotal);
        public string Status { get; set; } = "Pendente"; // Ex: "Pendente", "Processando", "Concluído", "Cancelado"
    }
}
