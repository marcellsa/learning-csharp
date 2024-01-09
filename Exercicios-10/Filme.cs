// 3.1 Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.
// 3.4 Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

namespace Alura.Filmes;

public class Filme
{
    // Propriedades do filme
    public List<Artista> Elenco { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }

    // Construtor
    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
            foreach (var artista in Elenco)
            {
                artista.AdicionarFilme(this);
            }
        }

        Titulo = titulo;
        Duracao = duracao;
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

    // Método para adicionar um artista ao elenco do filme
    public void AdicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.FilmesAtuados.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"{artista} adicionado/a ao elenco.");
    }
}
