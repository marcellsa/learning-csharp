// 2.2 Modelar o funcionamento de uma oficina automobilistica.
namespace Exercicios_11.Automobilistica.Models;

public class Veiculo
{
  public string Marca { get; set; }
  public string Modelo { get; set; }
  public int Ano { get; set; }
  public string Placa { get; set; }

  public Veiculo(string marca, string modelo, int ano, string placa)
  {
      Marca = marca;
      Modelo = modelo;
      Ano = ano;
      Placa = placa;
  }
}