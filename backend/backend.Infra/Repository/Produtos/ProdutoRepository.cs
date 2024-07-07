using backend.Domain.Entidade;

namespace backend.Infra.Repository.Produtos;

public class ProdutoRepository : IProdutoRepository
{
    public static List<Produto> _produtoLista = new List<Produto> {
            new Produto { Codigo = 001, Nome = "Produto A", Descricao = "Especificação / Descrição do produto genérico 1", Quantidade = 100, Fornecedor1 = 100, Fornecedor2 = 100, Fornecedor3 = 100, Fornecedor4 = 100 },
            new Produto { Codigo = 002, Nome = "Produto B", Descricao = "Especificação / Descrição do produto genérico 2", Quantidade = 100, Fornecedor1 = 100, Fornecedor2 = 100, Fornecedor3 = 100, Fornecedor4 = 100 },
            new Produto { Codigo = 003, Nome = "Produto C", Descricao = "Especificação / Descrição do produto genérico 3", Quantidade = 100, Fornecedor1 = 100, Fornecedor2 = 100, Fornecedor3 = 100, Fornecedor4 = 100 },
            new Produto { Codigo = 004, Nome = "Produto D", Descricao = "Especificação / Descrição do produto genérico 4", Quantidade = 100, Fornecedor1 = 100, Fornecedor2 = 100, Fornecedor3 = 100, Fornecedor4 = 100 },
            new Produto { Codigo = 005, Nome = "Produto E", Descricao = "Especificação / Descrição do produto genérico 5", Quantidade = 100, Fornecedor1 = null, Fornecedor2 = null, Fornecedor3 = null, Fornecedor4 = null },
            new Produto { Codigo = 006, Nome = "Produto F", Descricao = "Especificação / Descrição do produto genérico 6", Quantidade = 100, Fornecedor1 = null, Fornecedor2 = null, Fornecedor3 = null, Fornecedor4 = null },
            new Produto { Codigo = 007, Nome = "Produto G", Descricao = "Especificação / Descrição do produto genérico 7", Quantidade = 100, Fornecedor1 = null, Fornecedor2 = null, Fornecedor3 = null, Fornecedor4 = null },
            new Produto { Codigo = 008, Nome = "Produto H", Descricao = "Especificação / Descrição do produto genérico 8", Quantidade = 100, Fornecedor1 = null, Fornecedor2 = null, Fornecedor3 = null, Fornecedor4 = null },
            new Produto { Codigo = 009, Nome = "Produto I", Descricao = "Especificação / Descrição do produto genérico 9", Quantidade = 100, Fornecedor1 = null, Fornecedor2 = null, Fornecedor3 = null, Fornecedor4 = null },
            new Produto { Codigo = 010, Nome = "Produto J", Descricao = "Especificação / Descrição do produto genérico 10", Quantidade =100, Fornecedor1 = null, Fornecedor2 = null, Fornecedor3 = null, Fornecedor4 = null }
    };

    public List<Produto> GetAll()
    {
        return _produtoLista;
    }

    public Produto? Get(int codigo)
    {
        return _produtoLista.FirstOrDefault(w => w.Codigo == codigo);
    }

    public void Update(Produto produto)
    {
        var produtoIndex = _produtoLista.FindIndex(w => w.Codigo == produto.Codigo);

        if (produtoIndex == -1)
            throw new Exception("Produto não para atualização.");

        _produtoLista[produtoIndex] = produto;
    }
}
