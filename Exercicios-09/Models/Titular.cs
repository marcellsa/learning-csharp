// 1.Criar um construtor para a classe Titular, que inicialize todas suas propriedades Nome , Cpf, Endereco
namespace Exercicios_09.Models;

public class Titular
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Endereco {get; set;}

    public Titular(string nome, string cpf, string endereco)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        this.Endereco = endereco;
    }
}