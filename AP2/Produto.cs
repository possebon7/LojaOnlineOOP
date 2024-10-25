
public abstract class Produto
{
    public string Nome {get; set;}
    public string Codigo {get; set;}
    public decimal Preco {get; set;}


    // CONSTRUTOR PARA PRODUTO
    public Produto(string nome, string codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }
    public abstract decimal calcularPrecoFinal();

}