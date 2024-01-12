// Desafio: hora da prática 02 do Curso C# - dominando Orientação á Objetos

// 2.1 Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

// 2.2 Modelar o funcionamento de uma oficina automobilistica.

// 2.3 Criar um programa Program.cs e simular o funcionamento do programa.
using Exercicios_11.Automobilistica.Models;

class Program
{
    static void Main()
    {
        // Criar instâncias de Veiculo, Cliente, Mecanico e Oficina
        Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
        Cliente cliente = new Cliente("Carlos", "987654321");
        Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
        Oficina oficina = new Oficina();

        // Agendar e realizar um serviço na oficina
        oficina.AgendarServico(meuCarro, cliente, mecanico, "2023-12-18");
        oficina.RealizarServico(meuCarro, mecanico);
    }
}
// 2.4 Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.