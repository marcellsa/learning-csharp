namespace Exercicios_11.PetShop.Models;

public class Medico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}