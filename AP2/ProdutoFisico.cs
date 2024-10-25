
public class ProdutoFisico : Produto
{
    public double Peso { get; set;}
    public string Categoria {get; set;}
    
    public Dimensoes Dimensao{get; set;}

    public ProdutoFisico(string nome, string codigo, decimal preco, double peso, string categoria, Dimensoes dimensao)
    : base(nome, codigo, preco)
    {   
        Peso = peso;
        Categoria = categoria;
        Dimensao = dimensao;

    }

    public override decimal calcularPrecoFinal()
    {
       decimal valorImposto = Preco * 0.1m; 
       decimal custoEnvio = (decimal)Peso * 5.0m;
       decimal precoFinal = Preco + valorImposto + custoEnvio;
       return precoFinal;
    }
}