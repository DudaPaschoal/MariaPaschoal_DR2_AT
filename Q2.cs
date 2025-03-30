using System;

namespace Q2
{
    public class ProgramQ2
    {
        public static void Executar()
        {
            Console.Clear(); 
            Console.WriteLine("Questão 2: Manipulação de Strings - Cifrador de Nome");
            Console.Write("\nDigite seu nome completo: ");

            string nome = Console.ReadLine();
            string nomeCifrado = CifrarNome(nome);

            Console.WriteLine($"\nNome cifrado: {nomeCifrado}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey(); 
        }

        private static string CifrarNome(string nome)
        {
            char[] caracteres = nome.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                char c = caracteres[i];

             
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

               
                if (char.IsLetter(c))
                {
                   
                    if (char.IsLower(c))
                    {
                        caracteres[i] = (char)((c - 'a' + 2) % 26 + 'a');
                    }
                    else if (char.IsUpper(c))
                    {
                        caracteres[i] = (char)((c - 'A' + 2) % 26 + 'A');
                    }
                }
            }

            return new string(caracteres);
        }
    }
}
