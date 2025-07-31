using Atividade6_Blazor.Models;

namespace Atividade6_Blazor.Services
{
    public class ProdutoService
    {
        private List<Produto> Lista_Produtos = new(){
        new Produto { Id = 1, Nome = "Notebook Dell", Preco = 3500m, Categoria = "Eletrônicos" },
        new Produto { Id = 2, Nome = "Mouse Logitech", Preco = 120m, Categoria = "Periféricos" },
        new Produto { Id = 3, Nome = "Monitor LG", Preco = 900m, Categoria = "Eletrônicos" },
        new Produto { Id = 4, Nome = "Teclado Mecânico", Preco = 250m, Categoria = "Periféricos" }
        };

        public List<Produto> ObterTodosProdutos()
        {
            return Lista_Produtos;
        }

        public Produto ObterProdutoPorId(int Id)
        {
            return Lista_Produtos.Find(produto => produto.Id == Id);
        }
    }
}
