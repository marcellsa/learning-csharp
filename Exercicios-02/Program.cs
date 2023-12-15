// Desafio: hora da prática 02 do Curso C# - criando sua primeira aplicação

// 1.Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
int media = 7;
if(media >= 5){
    Console.WriteLine("Nota suficiente para aprovação");
}

// 2.Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
List<string> linguagens = new List<string> {"C#", "Java", "JavaScript"};

// 3.Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
Console.WriteLine(linguagens[0]);

// 4.Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
int[] lista = { 10, 20, 30, 40, 50 };
Console.WriteLine($"Insira um número inteiro entre 1 e {lista.Length}: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"A n-ésima posição da lista é: {lista[n - 1]}");
