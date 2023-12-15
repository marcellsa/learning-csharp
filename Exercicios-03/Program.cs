// Desafio: hora da prática 03 do Curso C# - criando sua primeira aplicação

// 1.Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
void ExibirQuatroOperacoes(){

float a = 4;
float b = 8;

float soma1 = a + b;
float subtracao1 = a - b;
float divisao1 = a / b;
float multiplicacao1 = a * b;

Console.WriteLine("\nResultado de suas quatro operações básicas:");
Console.WriteLine($"a + b = {soma1}");
Console.WriteLine($"a - b = {subtracao1}");
Console.WriteLine($"a / b = {divisao1}");
Console.WriteLine($"a * b = {multiplicacao1}");
}

ExibirQuatroOperacoes();

// 2.Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
List<string> bandas = new List<string>();

bandas.Add("The Rolling Stones");
bandas.Add("U2");
bandas.Add("Radiohead");

// 3.Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
Console.WriteLine("\nMinhas bandas preferidas:");
for(int i = 0; i < bandas.Count; i++){
    Console.WriteLine(bandas[i]);
}

// 4.Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int soma4 = 0;

Console.WriteLine("\nA soma de todos os elementos inteiros em uma lista:");
foreach (int numero in numeros)
{
    soma4 += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma4}");

// 5.Criar um programa que calcula a média dos elementos de ponto flutuante em uma lista.
List<double> numeros5 = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
double soma5 = 0;

Console.WriteLine("\nA média dos elementos de ponto flutuante em uma lista:");
foreach (double numero5 in numeros5)
{
    soma5 += numero5;
}

double media5 = soma5 / numeros5.Count;
Console.WriteLine($"A média dos elementos da lista é: {media5}");

// 6.Desenvolver um programa que exibe a tabuada de um número.
int numero6 = 7;

Console.WriteLine($"\nTabuada do {numero6}:");

for (int i = 1; i <= 10; i++)
{
    int resultado = numero6 * i;
    Console.WriteLine($"{numero6} x {i} = {resultado}");
}

// 7. Desenvolver uma calculadora simples que realiza as quatro operações básicas, a partir dado dois numeros e um operador.

double numero71 = 5;
double numero72 = 4;
char operacao = '+';

double resultado7 = 0;

switch (operacao)
{
    case '+':
        resultado7 = numero71 + numero72;
        break;
    case '-':
        resultado7 = numero71 - numero72;
        break;
    case '*':
        resultado7 = numero71 * numero72;
        break;
    case '/':
        resultado7 = numero71 / numero72;
        break;
    default:
        Console.WriteLine("Operação inválida.");
        return;
}

Console.WriteLine($"\nResultado da operação: {resultado7}\n");
