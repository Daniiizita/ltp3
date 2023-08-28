﻿// Lista de Exercícios em C# no 1.0

// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

// 02 - Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

// 03 - Elabore um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.

// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.

// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.

// Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.


using System;

namespace ExerciciosCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha um exercício para executar (1 a 6) ou 0 para sair:");
                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Exercicio1.Executar();
                        break;
                    case 2:
                        Exercicio2.Executar();
                        break;
                    case 3:
                        Exercicio3.Executar();
                        break;
                    case 4:
                        Exercicio4.Executar();
                        break;
                    case 5:
                        Exercicio5.Executar();
                        break;
                    case 6:
                        Exercicio6.Executar();
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Encerrando o programa.");
        }
    }
}

