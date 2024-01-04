// 3.1 Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

namespace Alura.Filmes;

public class Filme
{
    // Propriedades do filme
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<string> Elenco { get; set; }

    // Construtor
    public Filme(string titulo, int duracao, List<string>? elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        if (elenco == null)
        {
            Elenco = new List<string>();
        }
        else
        {
            Elenco = elenco;
        }
    }

    // Método para exibir informações do filme
    public void ExibirInformacoesDoFilme()
    {
        Console.WriteLine("\nInformações sobre o Filme:");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao} minutos");
        Console.WriteLine("Elenco:");             
        if(Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio.");
        }
        else
        {
            foreach(var artista in Elenco)
            {
                Console.WriteLine($"- {artista}");
            }
        }        
    }
}
