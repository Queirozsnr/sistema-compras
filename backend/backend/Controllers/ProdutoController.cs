using backend.Domain.Entidade;
using backend.Infra.Repository.Produtos;
using backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }


    [HttpGet]
    public IActionResult Get()
    {
        var produtoLista = _produtoRepository.GetAll();

        return Ok(produtoLista);
    }

    [HttpPut("{codigo}")]
    public IActionResult Put(int codigo, [FromBody] ProdutoModel produto)
    {
        var produtoDb = _produtoRepository.Get(codigo);

        if (produtoDb == null)
            return NotFound();

        var produtoUpdate = new Produto(
            produto.Codigo,
            produto.Nome,
            produto.Descricao,
            produto.Quantidade,
            produto.Fornecedor1,
            produto.Fornecedor2,
            produto.Fornecedor3,
            produto.Fornecedor4);

        _produtoRepository.Update(produtoUpdate);

        return Ok();
    }
}
