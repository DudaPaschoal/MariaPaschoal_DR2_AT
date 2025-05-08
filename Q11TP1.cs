using System;
using System.Threading;

namespace Q11TP1
{

    class ProgramQ11TP1
    {
        public static void Executar()
        {
            Func<string, string, string> processarNome = ConcatenarNome;

            processarNome += ConverterParaMaiusculas;
            processarNome += RemoverEspacos;

            string nome = "Maria ";
            string sobrenome = " Eduarda Lobato";
            string resultado = processarNome.Invoke(nome, sobrenome);

            Console.WriteLine($"Resultado final: \"{resultado}\"");

            /*
             * 
             * O resultado esperado seria que ficasse MARIA EDUARDA LOBATO, porem, ao utilizar delegate multicast somente o resultado do ultimo delegate foi retornado
             * assim, a resposta acabou sendo Maria, removendo somente os espacos em branco, por ter sido o ultimo a ser chamado
             * 
             */
            Console.ReadKey();

        }

        static string ConcatenarNome(string nome, string sobrenome)
        {
            string resultado = nome + " " + sobrenome;
            Console.WriteLine($"Resultado de Concatenar -> \"{resultado}\"");
            return resultado;
        }

        static string ConverterParaMaiusculas(string nome, string sobrenome)
        {
            string resultado = nome.ToUpper();
            Console.WriteLine($"Resultado de Maiúsculas -> \"{resultado}\"");
            return resultado;
        }

        static string RemoverEspacos(string texto, string _)
        {
            string resultado = texto.Replace(" ", "");
            Console.WriteLine($"Resultado de Sem espaços -> \"{resultado}\"");
            return resultado;
        }
    }
}
