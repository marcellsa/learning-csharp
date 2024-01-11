namespace Exercicios_11.PetShop.Models;

public class Pet
{
  public string Nome { get; set; }
  public string Idade { get; set; }
  public string Especie { get; set; }

  public Pet(string nome, string idade, string especie)
  {
    Nome = nome;
    Idade = idade;
    Especie = especie;
  }
}