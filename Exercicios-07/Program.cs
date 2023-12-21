// Desafio: hora da prática 02 do Curso C# - aplicando a Orientação a Objetos
namespace Exercicios_07;

// 1.Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
class Conta
{
    public string Titular { get; set; }
    public int Id { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }
}

// 2.Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
// 3. Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
class Carro
{
    private int ano;
    public string Fabricante {get; set;}
    public string Modelo {get; set;}
    public int Ano {
        get => ano; 
        set 
        {
            if(value < 1960 || value > 2023){
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            } else {
                ano = value;
            }
        }
    }
    public int QuantidadePortas{get; set;}
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";
}

// 4.Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.
class Produto
{
    private double preco;
    private int estoque;
    public string Nome {get; set;}
    public string Marca {get; set;}
    public double Preco {
        get => preco; 
        set
        {
            if(value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    
    public int Estoque {
        get => estoque; 
        set 
        {
            if(value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string DescricaoProduto => $"{this.Nome} {this.Marca} - {this.Preco}";

}

class Program
{
    static void Main(string[] args)
    {
        Conta minhaConta = new Conta();
        minhaConta.Titular = "Marcel Albuquerque";
        minhaConta.Id = 123456;
        minhaConta.Saldo = 1000.50f;
        minhaConta.Senha = 1234;
        Console.WriteLine("\nInformações da Conta:");
        Console.WriteLine($"Titular: {minhaConta.Titular}");
        Console.WriteLine($"ID: {minhaConta.Id}");
        Console.WriteLine($"Saldo: R${minhaConta.Saldo}");
        Console.WriteLine($"Senha: {minhaConta.Senha}");

        Carro meuCarro = new Carro();
        meuCarro.Fabricante = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2020;
        meuCarro.QuantidadePortas = 4;
        Console.WriteLine("\nInformações do Carro:");
        Console.WriteLine($"Fabricante: {meuCarro.Fabricante}");
        Console.WriteLine($"Modelo: {meuCarro.Modelo}");
        Console.WriteLine($"Ano: {meuCarro.Ano}");
        Console.WriteLine($"Quantidade de Portas: {meuCarro.QuantidadePortas}");
        Console.WriteLine($"Descrição Detalhada: {meuCarro.DescricaoDetalhada}");

        Produto meuProduto = new Produto();
        meuProduto.Nome = "Notebook";
        meuProduto.Marca = "Dell";
        meuProduto.Preco = 2500.99;
        meuProduto.Estoque = 50;
        Console.WriteLine("\nInformações do Produto:");
        Console.WriteLine($"Nome: {meuProduto.Nome}");
        Console.WriteLine($"Marca: {meuProduto.Marca}");
        Console.WriteLine($"Preço: R${meuProduto.Preco}");
        Console.WriteLine($"Estoque: {meuProduto.Estoque}");
        Console.WriteLine($"Descrição do Produto: {meuProduto.DescricaoProduto}");
    }
}
