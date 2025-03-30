using System;

namespace Q4
{
    public class ProgramQ4
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Questão 4: Manipulação de Datas - Dias até o Próximo Aniversário");

           
            DateTime dataNascimento = LerData("Digite sua data de nascimento (dd/MM/yyyy): ");

            DateTime hoje = DateTime.Today;

            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

      
            int diasFaltando = (proximoAniversario - hoje).Days;

      
            Console.WriteLine($"\nFaltam {diasFaltando} dia(s) para seu próximo aniversário!");

            if (diasFaltando < 7)
            {
                Console.WriteLine("🎉 Seu aniversário está chegando! Prepare-se para comemorar! 🎂");
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
