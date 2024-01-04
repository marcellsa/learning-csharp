// Desafio: hora da prática 01 do Curso C# - dominando Orientação á Objetos

// 3.1 Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

// 3.2 Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
using Alura.Filmes;

Filme filme1 = new Filme("Um sonho de liberdade", 142, new List<string>() {"Tim Robbins", "Morgan Freeman" });
Filme filme2 = new Filme("O poderoso chefão", 175, new List<string>() { "Marlon Brando", "Al Pacino", "Talia Shire"});
Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<string>() {"Christian Bale", "Heath Ledger", "Maggie Gyleenhaal" });
Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<string>() {"Elijah Wood", "Ian McKellen", "Viggo Mortensen" });
Filme filme5 = new Filme("Green Book - O Guia", 130, new List<String>() { "Viggo Mortensen", "Mahershala Ali" });

filme1.ExibirInformacoesDoFilme();
filme2.ExibirInformacoesDoFilme();
filme3.ExibirInformacoesDoFilme();
filme4.ExibirInformacoesDoFilme();
filme5.ExibirInformacoesDoFilme();

// 3.3 Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

// 3.4 Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.