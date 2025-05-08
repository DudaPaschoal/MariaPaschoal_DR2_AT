
using Q1TP1;
using Q2TP1;
using Q3TP1;
using Q4TP1;
using Q5TP1;
using Q6TP1;
using Q7TP1;
using Q11TP1;
namespace MariaPaschoal_DR4_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha a questão para executar:");
                Console.WriteLine("1 - Questão 1");
                Console.WriteLine("2 - Questão 2");
                Console.WriteLine("3 - Questão 3");
                Console.WriteLine("4 - Questão 4");
                Console.WriteLine("5 - Questão 5");
                Console.WriteLine("6 - Questão 6");
                Console.WriteLine("7 - Questão 7");
                Console.WriteLine("11 - Questão 11");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite sua escolha: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        ProgramQ1TP1.Executar();
                        break;
                    case "2":
                        ProgramQ2TP1.Executar();
                        break;
                    case "3":
                        ProgramQ3TP1.Executar();
                        break; ;
                    case "4":
                        ProgramQ4TP1.Executar();
                        break;
                    case "5":
                        ProgramQ5TP1.Executar();
                        break;
                    case "6":
                        ProgramQ6TP1.Executar();
                        break;
                    case "7":
                        ProgramQ7TP1.Executar();
                        break;
                    case "11":
                        ProgramQ11TP1.Executar();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
