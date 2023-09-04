// See https://aka.ms/new-console-template for more information

/* Exercício: Derivação de Sentenças com uma Gramática Simples

Considere a seguinte gramática de exemplo:

1. S -> NP VP
2. NP -> Det N
3. NP -> N
4. VP -> V NP
5. Det -> 'o'
6. N -> 'gato' | 'cachorro'
7. V -> 'persegue' | 'late'

Aqui, S representa a sentença, NP o sintagma nominal, VP o sintagma verbal, Det o determinante, N o substantivo e V o verbo. As regras da gramática indicam como as sentenças podem ser formadas.

Tarefa:

Comece com a sentença inicial S.
Use as regras gramaticais para derivar uma sentença válida.
Escreva cada etapa da derivação até que você obtenha uma sentença terminal.
Conte o número de etapas até chegar ao final
*/

using System;

namespace DerivacaoDeSentenca
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenca = DerivarSentenca();
            Console.WriteLine($"Sentença final: {sentenca}");
        }

        static string DerivarSentenca()
        {
            // Começamos com a sentença inicial S
            string sentenca = DerivarNP() + " " + DerivarVP();
            return sentenca;
        }

        static string DerivarNP()
        {
            Random random = new Random();
            int escolha = random.Next(2); // Gera 0 ou 1 aleatoriamente

            if (escolha == 0)
            {
                // Usamos a regra NP -> Det N
                return DerivarDet() + " " + DerivarN();
            }
            else
            {
                // Usamos a regra NP -> N
                return DerivarN();
            }
        }

        static string DerivarVP()
        {
            // Usamos a regra VP -> V NP
            return DerivarV() + " " + DerivarNP();
        }

        static string DerivarDet()
        {
            // Sempre usamos 'o' como determinante
            return "o";
        }

        static string DerivarN()
        {
            Random random = new Random();
            int escolha = random.Next(2); // Gera 0 ou 1 aleatoriamente

            if (escolha == 0)
            {
                // Escolhemos 'gato'
                return "gato";
            }
            else
            {
                // Escolhemos 'cachorro'
                return "cachorro";
            }
        }

        static string DerivarV()
        {
            Random random = new Random();
            int escolha = random.Next(2); // Gera 0 ou 1 aleatoriamente

            if (escolha == 0)
            {
                // Escolhemos 'persegue'
                return "persegue";
            }
            else
            {
                // Escolhemos 'late'
                return "late";
            }
        }
    }
}

