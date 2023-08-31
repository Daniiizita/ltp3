using System;

namespace Atividades3082023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar o nome completo ao usuário
            Console.Write("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            // Solicitar a idade ao usuário
            Console.Write("Digite sua idade: ");
            string idadeStr = Console.ReadLine();

            // Converter a idade para um número inteiro
            int idade = Convert.ToInt32(idadeStr);

            // Exibir o nome completo em maiúsculas
            Console.WriteLine("Nome em maiúsculas: " + nomeCompleto.ToUpper());

            // Exibir o nome completo em minúsculas
            Console.WriteLine("Nome em minúsculas: " + nomeCompleto.ToLower());

            // Contar o número de caracteres no nome completo (ignorando espaços)
            int numeroCaracteres = nomeCompleto.Replace(" ", "").Length;
            Console.WriteLine("Número de caracteres no nome: " + numeroCaracteres);

            // Calcular o ano de nascimento
            int anoAtual = 2023;
            int anoNascimento = anoAtual - idade;
            Console.WriteLine("Ano de nascimento: " + anoNascimento);

            // Calcular o ano em que o usuário fará 100 anos
            int anoCemAnos = anoNascimento + 100;
            Console.WriteLine("Você fará 100 anos em: " + anoCemAnos);

            // Aguardar ação do usuário para encerrar o programa
            Console.ReadLine();
        }
    }
}

