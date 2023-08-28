// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.
using System;

namespace ExerciciosCSharp3
{
    class Exercicio4
    {
        public static void Executar()
        {
            Console.WriteLine("Executando Exercício 4");
            
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }
    }
}