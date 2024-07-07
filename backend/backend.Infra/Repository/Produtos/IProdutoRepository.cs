using backend.Domain.Entidade;

namespace backend.Infra.Repository.Produtos;

public interface IProdutoRepository
{
    List<Produto> GetAll();
    Produto? Get(int codigo);
    void Update(Produto produto);
}
