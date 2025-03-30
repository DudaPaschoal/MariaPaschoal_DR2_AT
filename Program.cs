using Q1;
using Q2;
using Q3;
using Q4;
using Q5;
using Q6;
using Q7;
using Q8;
using Q9_Array;
using Q9_File;
using Q10;
using Q11;
using Q12;

namespace MariaPaschoal_DR2_TP2
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
                Console.WriteLine("8 - Questão 8");
                Console.WriteLine("9A - Questão 9A");
                Console.WriteLine("9B - Questão 9B");
                Console.WriteLine("10 - Questão 10");
                Console.WriteLine("11 - Questão 11");
                Console.WriteLine("12 - Questão 12");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite sua escolha: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        ProgramQ1.Executar();
                        break;
                    case "2":
                        ProgramQ2.Executar();
                        break;
                    case "3":
                        ProgramQ3.Executar();
                        break; ;
                    case "4":
                        ProgramQ4.Executar();
                        break;
                    case "5":
                        ProgramQ5.Executar();
                        break;
                    case "6":
                        ProgramQ6.Executar();
                        break;
                    case "7":
                        ProgramQ7.Executar();
                        break;
                    case "8":
                        ProgramQ8.Executar();
                        break;
                    case "9A":
                        ProgramQ9Array.Executar();
                        break;
                    case "9B":
                        ProgramQ9File.Executar();
                        break;
                    case "10":
                        ProgramQ10.Executar();
                        break;
                    case "11":
                        ProgramQ11.Executar();
                        break;
                    case "12":
                        ProgramQ12.Executar();
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
