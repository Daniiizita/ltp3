// Exercício em C# 
/*

Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

*/


using System;

namespace NomeSobrenome
{
    class NomeSobrenome
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
        }
    }
}
