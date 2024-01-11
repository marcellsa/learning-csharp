namespace Exercicios_11.PetShop.Models;
public class Dono
{
    public string Nome { get; set; }
    public string Contato { get; set; }

    public Dono(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }
}