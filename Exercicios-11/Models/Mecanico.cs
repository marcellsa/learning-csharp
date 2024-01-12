// 2.2 Modelar o funcionamento de uma oficina automobilistica.
namespace Exercicios_11.Automobilistica.Models;

public class Mecanico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Mecanico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}