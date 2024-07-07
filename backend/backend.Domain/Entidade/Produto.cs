namespace backend.Domain.Entidade;

public class Produto
{
    public Produto(int codigo, string nome, string descricao, int quantidade, float? fornecedor1, float? fornecedor2, float? fornecedor3, float? fornecedor4)
    {
        Codigo = codigo;
        Nome = nome;
        Descricao = descricao;
        Quantidade = quantidade;
        Fornecedor1 = fornecedor1;
        Fornecedor2 = fornecedor2;
        Fornecedor3 = fornecedor3;
        Fornecedor4 = fornecedor4;
    }

    public Produto()
    {
        
    }

    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
    public float? Fornecedor1 { get; set; }
    public float? Fornecedor2 { get; set; }
    public float? Fornecedor3 { get; set; }
    public float? Fornecedor4 { get; set; }
}
