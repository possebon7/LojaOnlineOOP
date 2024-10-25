
public class Pedido : ICarriavel
{
    public Cliente Cliente {get;  set;}
    public DateTime DataPedido {get;  set;}
    public Status Status {get;  set;}
    public List<Produto> Produtos {get;  set;}

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = Status.EmProcessamento;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto == null) {return;}
        Produtos.Add(produto);

    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        
        foreach (var produto in Produtos)
        {
           total = total + produto.calcularPrecoFinal(); 
        }
        return total;
    }

    public void RemoverProduto(Produto produto)
    {
      if (Produtos.Contains(produto)){
        Produtos.Remove(produto);
      }
    }
    public void FinalizarPedido()
    {
        Status = Status.Concluído;
    }
}