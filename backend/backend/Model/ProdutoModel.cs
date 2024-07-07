namespace backend.Model;

public class ProdutoModel
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
    public float? Fornecedor1 { get; set; }
    public float? Fornecedor2 { get; set; }
    public float? Fornecedor3 { get; set; }
    public float? Fornecedor4 { get; set; }
}