using Atividade6_Blazor.Models;

namespace Atividade6_Blazor.Services
{
    public class PedidoService
    {
        private List<Pedido> Lista_Pedidos = new();

        public void AdicionarPedido(Pedido pedido)
        {
            pedido.Id = Lista_Pedidos.Count() + 1;
            Lista_Pedidos.Add(pedido);
        }

        public void AtualizarPedido(Pedido pedido)
        {
            var existente = ObterPedidoPorId(pedido.Id);

            if(existente != null)
            {
                int index = Lista_Pedidos.IndexOf(existente);
                Lista_Pedidos[index] = pedido;
            }
        }

        public void RemoverPedido(Pedido pedido)
        {
            Lista_Pedidos.Remove(pedido);
        }

        public List<Pedido> ObterTodosPedidos()
        {
            return Lista_Pedidos;
        }

        public Pedido ObterPedidoPorId(int id)
        {
            Pedido pedido = Lista_Pedidos.Find(pedido => pedido.Id == id);

            return pedido;
        }


    }
}
