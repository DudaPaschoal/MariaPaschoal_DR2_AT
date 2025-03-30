using System;

namespace Q3
{
    public class ProgramQ3
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Questão 3: Calculadora de Operações Matemáticas");

            double numero1 = LerNumero("Digite o primeiro número: ");
            double numero2 = LerNumero("Digite o segundo número: ");

            // Exibir o menu de operações
            Console.WriteLine("\nEscolha uma operação matemática:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Digite sua escolha (1, 2, 3 ou 4): ");

            string escolha = Console.ReadLine();
            double resultado;

            switch (escolha)
            {
                case "1":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"\nResultado da soma: {resultado}");
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"\nResultado da subtração: {resultado}");
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"\nResultado da multiplicação: {resultado}");
                    break;
                case "4":
                    if (numero2 == 0)
                    {
                        Console.WriteLine("\nErro: Divisão por zero não é permitida!");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"\nResultado da divisão: {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Por favor, escolha uma operação válida.");
                    break;
            }

     
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        private static double LerNumero(string mensagem)
        {
            double numero;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out numero))
                {
                    return numero; 
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
                }
            }
        }
    }
}
