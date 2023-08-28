// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

using System;

namespace ExerciciosCSharp3
{
    class Exercicio1
    {
        public static void Executar()
        {
            Console.WriteLine("Executando Exercício 1");
            
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

        }
    }
}