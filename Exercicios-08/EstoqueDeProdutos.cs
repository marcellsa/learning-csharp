// 3.Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
class EstoqueDeProdutos
{
    private List<Produto> Produtos {get; set;} = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos()
    {
        if(Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach(var produto in Produtos){
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}