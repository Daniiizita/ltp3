// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.
using System;

namespace ExerciciosCSharp3
{
    class Exercicio6
    {
        public static void Executar()
        {
            Console.WriteLine("Executando Exercício 6");
            
            Console.WriteLine("Digite um número inteiro:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais. O triplo da soma entre eles é " + (numero1 + numero2) * 3);
            }
            else
            {
                Console.WriteLine("Os números são diferentes. A soma entre eles é " + (numero1 + numero2));
            }''
        }
    }
}