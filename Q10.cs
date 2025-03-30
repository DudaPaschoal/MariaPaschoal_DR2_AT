using System;

namespace Q10
{
    public class ProgramQ10
    {
        public static void Executar()
        {
            Console.Clear(); 
            Console.WriteLine("Questão 10: Jogo de Adivinhação");

           
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);

            int tentativasRestantes = 5; 
            bool acertou = false; 

            Console.WriteLine("\nTente adivinhar o número secreto (entre 1 e 50). Você tem 5 tentativas!");

            while (tentativasRestantes > 0 && !acertou)
            {
                try
                {
                    Console.Write($"\nTentativa {6 - tentativasRestantes}: Digite seu palpite: ");
                    int palpite = int.Parse(Console.ReadLine());

                    if (palpite < 1 || palpite > 50)
                    {
                        Console.WriteLine("Erro: O número deve estar entre 1 e 50. Tente novamente.");
                        continue;
                    }

                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine("\nParabéns! Você acertou o número secreto!");
                        acertou = true;
                    }
                    else if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior!");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor!");
                    }

                    tentativasRestantes--; 
                }
                catch (FormatException)
                {
              
                    Console.WriteLine("Erro: Entrada inválida! Por favor, digite um número.");
                }
            }

            if (!acertou)
            {
                Console.WriteLine($"\nVocê perdeu! O número secreto era {numeroSecreto}.");
            }

    
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
