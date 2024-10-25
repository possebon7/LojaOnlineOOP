
public class Loja
{
    public List <Produto> Produtos {get; set;}
    public List <Cliente> Clientes {get; set;}
    public List <Pedido> Pedidos {get; set;}
    
    public Loja()
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
        Pedidos = new List<Pedido>();
    }
    //GERENCIAMENTO DE PRODUTOS: 

    public void CadastrarProduto (Produto produto)
    {
         if (produto == null) {return;}
         if (Produtos.Contains(produto)) {return;}
         Produtos.Add(produto);
         Console.WriteLine("Produto cadastrado!");
        
    }
    public void ConsultarProdutoPorCodigo (string codigo)
    {
        Produto? produto = Produtos.FirstOrDefault(produto => produto.Codigo == codigo);
        Console.WriteLine($"Produto: {produto}");
    }
    public void ListarProdutos()
    {
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Produtos:{produto.Nome}");
        }
    }
    //GERENCIAMENTO DE CLIENTES:
    public void CadastrarCliente (Cliente cliente)
    {
        if (cliente == null) {return;}
         if (Clientes.Contains(cliente)) {return;}
         Clientes.Add(cliente);
         Console.WriteLine("Cliente cadastrado!");

    }
    public void ConsultarClientePorID(string numeroIdentificacao)
    {
        Cliente? cliente = Clientes.FirstOrDefault(cliente => cliente.NumeroIdentificacao == numeroIdentificacao);
        Console.WriteLine($"Cliente: {cliente}");
    }
    public void ListarClientes ()
    {
        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Clientes:{cliente}");
        }
    }
    //GERENCIAMENTO DE PEDIDOS
    public void CriarPedido(Cliente cliente)
    {
        if (Clientes.Contains(cliente)) {return;}
        Pedido pedido = new Pedido(cliente : cliente);
        Pedidos.Add(pedido);
    }
    public void FinalizarPedido(Pedido pedido)
    {
        pedido.FinalizarPedido();
        pedido.Status = Status.Concluído;
        Console.WriteLine("Pedido concluido");
    }
    public void ListarPedidos()
    {
         foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"Pedido:{pedido}");
        }
    }


}