// 3.1 Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

namespace Alura.Filmes;

public class Filme
{
    // Propriedades do filme
    public string Titulo { get; set; }
    public int Durcao { get; set; }
    public List<string> Elenco { get; set; }

    // Construtor
    public Filme(string titulo, int duracao, List<string> elenco)
    {
        Titulo = titulo;
        Durcao = Durcao;
        Elenco = elenco;
    }
}
