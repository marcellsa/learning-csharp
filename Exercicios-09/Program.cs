// Desafio: hora da prática 04 do Curso C# - aplicando a Orientação a Objetos
using Exercicios_09.Models;
namespace Exercicios_09;

class Program
{
    static void Main(string[] args)
    {
        // 1.Criar um construtor para a classe Titular, que inicialize todas suas propriedades Nome , Cpf, Endereco
        // 2.Criar um construtor para a classe Conta, que inicialize todas suas propriedades Titular, Agencia, NumeroDaConta, Saldo, Limite
        // 3.Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.
        Titular titular = new Titular("João Silva", "123.456.789-00", "Rua Exemplo, 123");

        // Criando uma conta usando o construtor
        Conta conta = new Conta(titular, 1234, 56789, 1000.00);

        // Exibindo informações da conta
        Console.WriteLine("Informações da Conta:");
        Console.WriteLine(conta.Informacoes);

        // 4.Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.
        // Instanciando um objeto da classe Jogo usando o construtor
        // Jogo meuJogo = new Jogo("Nome do Jogo", "Gênero do Jogo", 2023);

        // Exibindo informações do jogo na tela
        // Console.WriteLine($"\nInformações do Jogo:\nNome: {meuJogo.Nome}, Gênero: {meuJogo.Genero}, Ano de Lançamento: {meuJogo.AnoLancamento}");
    }
}
