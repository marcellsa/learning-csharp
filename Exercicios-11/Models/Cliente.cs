namespace Exercicios_11.Automobilistica.Models;

public class Cliente
{
  public string Nome { get; set; }
  public string Contato { get; set; }

  public Cliente(string nome, string contato)
  {
      Nome = nome;
      Contato = contato;
  }
}