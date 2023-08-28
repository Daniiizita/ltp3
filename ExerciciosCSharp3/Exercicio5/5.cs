// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.
using System;

namespace ExerciciosCSharp3
{
    class Exercicio5
    {
        public static void Executar()
        {
            Console.WriteLine("Executando Exercício 5");
            
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é ímpar.");
            }
        }
    }
}