// 03 - Elabore um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.
using System;

namespace ExerciciosCSharp3
{
    class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("Executando Exercício 3");
            
            int data_nascimento;
            int ano_atual = DateTime.Now.Year;

            Console.WriteLine("Digite o ano de nascimento: ");
            data_nascimento = Convert.ToInt32(Console.ReadLine());
            int idade = ano_atual - data_nascimento;

            Console.WriteLine("Sua idade é: " + idade);
        }
    }
}
