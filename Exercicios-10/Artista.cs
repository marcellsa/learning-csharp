// 3.3 Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
// 3.4 Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

namespace Alura.Filmes;
   
public class Artista
{
    // Propriedades do artista
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }

    // Construtor da classe
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    // Método para adicionar um filme em que o artista atuou
    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);        

        // Adicionar o artista à lista de elenco do filme
        if(!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }

    // Método para exibir informações do artista
    public void ExibirInformacoesDoArtista()
    {
        Console.WriteLine("Informações sobre o artista");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine("Filmes em que atuou:");
        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"- {filme.Titulo}");
        }
    }
}