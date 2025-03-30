using System;

namespace Q5
{
    public class ProgramQ5
    {
        public static void Executar()
        {
            Console.Clear(); 
            Console.WriteLine("Questão 5: Tempo Restante para Conclusão do Curso");

            DateTime dataFormatura = new DateTime(2026, 12, 15);

            DateTime dataAtual = LerData("Digite a data atual (dd/MM/yyyy): ");

            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("\nErro: A data informada não pode ser no futuro!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                return;
            }

            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("\nParabéns! Você já deveria estar formado!");
            }
            else
            {
                TimeSpan diferenca = dataFormatura - dataAtual;

                
                int anos = dataFormatura.Year - dataAtual.Year;
                int meses = dataFormatura.Month - dataAtual.Month;
                int dias = dataFormatura.Day - dataAtual.Day;

                if (dias < 0)
                {
                    dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
                    meses--;
                }

                if (meses < 0)
                {
                    meses += 12;
                    anos--;
                }

                Console.WriteLine($"\nFaltam {anos} ano(s), {meses} mês(es) e {dias} dia(s) para sua formatura!");

             
                if (anos == 0 && meses < 6)
                {
                    Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                }
            }

      
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        private static DateTime LerData(string mensagem)
        {
            DateTime data;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
                {
                    return data; 
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite uma data válida no formato dd/MM/yyyy.");
                }
            }
        }
    }
}
