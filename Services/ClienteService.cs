using Atividade6_Blazor.Models;

namespace Atividade6_Blazor.Services
{
    public class ClienteService
    {
        private List<Cliente> Lista_Clientes = new(){
        new Cliente { Id = 1, Nome = "Cesar Tralle", Email="CesarTralle@gmail.com"},
        new Cliente { Id = 2, Nome = "Nilmar Neto", Email="NilmarNeto@gmail.com" },
        new Cliente { Id = 3, Nome = "Dr. Octavius", Email="DrOctavius@gmail.com" }
        };

        public void AdicionarCliente(Cliente cliente)
        {
            Lista_Clientes.Add(cliente);
        }

        public List<Cliente> ObterTodosClientes()
        {
            return Lista_Clientes;
        }

        public Cliente ObterClientePorId(int Id)
        {
            return Lista_Clientes.Find(cliente => cliente.Id == Id);
        }
    }
}
