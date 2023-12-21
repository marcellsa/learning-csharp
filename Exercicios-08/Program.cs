// Desafio: hora da prática 03 do Curso C# - aplicando a Orientação a Objetos
namespace Exercicios_08;

class Program
{
    
    static void Main(string[] args)
    {
        // 1.Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
        // 2.Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
        Titular titular = new Titular();
        titular.Nome = "João Silva";
        titular.Cpf = "123.456.789-00";
        titular.Endereco = "Rua Exemplo, 123";

        Conta conta = new Conta();
        conta.Titular = titular;
        conta.Agencia = 1234;
        conta.NumeroDaConta = 56789;
        conta.Saldo = 1000.00;
        conta.Limite = 500.00;

        Console.WriteLine("\nInformações da Conta:");
        Console.WriteLine(conta.Informacoes);

        // 3.Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
        Produto produto1 = new Produto();
        produto1.Nome = "Notebook";
        produto1.Marca = "ABC";
        produto1.Preco = 1500.00;
        produto1.Estoque = 10;

        EstoqueDeProdutos estoque = new EstoqueDeProdutos();
        estoque.AdicionarProduto(produto1);

        Console.WriteLine("\nProdutos no Estoque:");
        estoque.ExibirProdutos();
    }
}



// 4.Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
}

class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
}

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();
}

// 5.Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
class ProdutoRestaurante
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Mesa
{
    public int Numero { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

class Pedido
{
    public ProdutoRestaurante Produto { get; set; }
    public int Quantidade { get; set; }
}

class Cardapio
{
    public List<ProdutoRestaurante> Itens { get; set; } = new List<ProdutoRestaurante>();
}

class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new List<Mesa>();
    public Cardapio Cardapio { get; set; } = new Cardapio();
}

