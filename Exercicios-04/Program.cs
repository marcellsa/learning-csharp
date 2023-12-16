// Desafio: hora da prática 04 do Curso C# - criando sua primeira aplicação

// 1.Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Martim"] = new List<double> { 7.0, 8.0, 6.5 };
notasAlunos["Aurora"] = new List<double> { 8.0, 8.0, 8.0 };
notasAlunos["Violeta"] = new List<double> { 9.5, 8.5, 7.5 };

Console.WriteLine("\nExibindo média dos alunos");
foreach (var aluno in notasAlunos)
{
    double soma = 0;
    for(int i = 0; i < aluno.Value.Count ; i++){
        soma += aluno.Value[i];
    }
    double media = soma / aluno.Value.Count;
    Console.WriteLine($"Média de {aluno.Key}: {media:F1}");
}

// 2.Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "camisetas", 50 },
    { "calças", 30 },
    { "tênis", 20 },
};

string produto = "camisetas";

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"\nQuantidade em estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine("\nProduto não encontrado no estoque.");
}

// 3.Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    { "Qual é a capital de Pernambuco?", "Recife" },
    { "Quem é o único campeão brasileiro de 87?", "Sport Recife" },
    { "Qual a maior avenvida em linha reta da América Latina?", "Av. Caxangá" },
};

int pontuacao = 0;

foreach (var pergunta in perguntasERespostas)
{
    Console.WriteLine("\n");
    Console.WriteLine(pergunta.Key);
    Console.Write("Sua resposta: ");
    string respostaUsuario = Console.ReadLine();

    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Correto!\n");
        pontuacao++;
    }
    else
    {
        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");


// 4.Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
Dictionary<string, string> usuarios = new Dictionary<string, string>
{
    { "user1", "senha123" },
    { "user2", "abc456" },
};

string nomeUsuario = "user1";
string senha = "senha123";

if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
    Console.WriteLine("\nLogin bem-sucedido!");
else
    Console.WriteLine("\nNome de usuário ou senha incorretos.");