// 02 - Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

using System;

namespace ExerciciosCSharp3
{
    class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("Executando Exercício 2");
            
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        }
    }
}
