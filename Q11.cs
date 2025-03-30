using System;
using System.IO;

namespace Q11
{
    public class ProgramQ11
    {
        public static void Executar()
        {
            string caminhoArquivo = "contatos.txt";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato(caminhoArquivo);
                        break;

                    case "2":
                        ListarContatos(caminhoArquivo);
                        break;

                    case "3":
                        Console.WriteLine("\nEncerrando programa...");
                        return;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void AdicionarContato(string caminhoArquivo)
        {
            try
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

               
                using (StreamWriter sw = File.AppendText(caminhoArquivo))
                {
                    sw.WriteLine($"{nome},{telefone},{email}");
                }

                Console.WriteLine("\nContato cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
           
                Console.WriteLine($"\nErro ao cadastrar contato: {ex.Message}");
            }
        }

        private static void ListarContatos(string caminhoArquivo)
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                   
                    File.Create(caminhoArquivo).Close();
                    Console.WriteLine("\nNenhum contato cadastrado.");
                    return;
                }

                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    bool temContatos = false;

                    while ((linha = sr.ReadLine()) != null)
                    {
                        temContatos = true;
                        string[] dados = linha.Split(',');

                        if (dados.Length == 3) 
                        {
                            string nome = dados[0];
                            string telefone = dados[1];
                            string email = dados[2];

                         
                            Console.WriteLine($"Nome: {nome} | Telefone: {telefone} | Email: {email}");
                        }
                        else
                        {
                          
                            Console.WriteLine("\nErro: Dados de contato mal formatados no arquivo.");
                        }
                    }

                    if (!temContatos)
                    {
                        Console.WriteLine("\nNenhum contato cadastrado.");
                    }
                }
            }
            catch (Exception ex)
            {
        
                Console.WriteLine($"\nErro ao listar contatos: {ex.Message}");
            }
        }
    }
}
