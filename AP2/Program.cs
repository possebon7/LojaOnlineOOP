public class Program{
    public static void Main(string[] args)
{
    Loja loja = new Loja();

    Console.Write("Digite o nome do produto que deseja cadastrar:");

    string nomeProduto = Console.ReadLine();

    ProdutoDigital produto = new ProdutoDigital(nomeProduto!, "7", 77, 99, "pdf");
    loja.CadastrarProduto(produto);
    Console.Write("Digite o nome do cliente:");
    string nomeCliente = Console.ReadLine();
    Cliente cliente = new Cliente(nomeCliente!, "1", "rua 2", "999999999");
    loja.CadastrarCliente(cliente);
    loja.ListarProdutos();
    



}

}

