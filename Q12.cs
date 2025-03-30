using System;
using System.Collections.Generic;
using System.IO;

namespace Q12
{

    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }


    public abstract class ContatoFormatter
    {
        public abstract void ExibirContatos(List<Contato> contatos);
    }

   
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("## Lista de Contatos\n");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato.Nome}");
                Console.WriteLine($"- 📞 Telefone: {contato.Telefone}");
                Console.WriteLine($"- 📧 Email: {contato.Email}\n");
            }
        }
    }

  
    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome           | Telefone      | Email          |");
            Console.WriteLine("----------------------------------------");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato.Nome,-14} | {contato.Telefone,-12} | {contato.Email,-15} |");
            }

            Console.WriteLine("----------------------------------------");
        }
    }

    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
            }
        }
    }


    public class ProgramQ12
    {
        private const string CaminhoArquivo = "contatos.txt";

        public static void Executar()
        {
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
                        AdicionarContato();
                        break;

                    case "2":
                        ListarContatos();
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

        private static void AdicionarContato()
        {
            try
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

            
                using (StreamWriter sw = File.AppendText(CaminhoArquivo))
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

        private static void ListarContatos()
        {
            try
            {
                if (!File.Exists(CaminhoArquivo))
                {
                    File.Create(CaminhoArquivo).Close();
                    Console.WriteLine("\nNenhum contato cadastrado.");
                    return;
                }

                List<Contato> contatos = new List<Contato>();

                using (StreamReader sr = new StreamReader(CaminhoArquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');
                        if (dados.Length == 3)
                        {
                            contatos.Add(new Contato
                            {
                                Nome = dados[0],
                                Telefone = dados[1],
                                Email = dados[2]
                            });
                        }
                    }
                }

                if (contatos.Count == 0)
                {
                    Console.WriteLine("\nNenhum contato cadastrado.");
                    return;
                }

       
                Console.WriteLine("\nEscolha o formato de exibição:");
                Console.WriteLine("1 - Markdown");
                Console.WriteLine("2 - Tabela");
                Console.WriteLine("3 - Texto Puro");
                Console.Write("Escolha uma opção: ");

                string formatoEscolhido = Console.ReadLine();

                ContatoFormatter formatter;

                switch (formatoEscolhido)
                {
                    case "1":
                        formatter = new MarkdownFormatter();
                        break;

                    case "2":
                        formatter = new TabelaFormatter();
                        break;

                    case "3":
                        formatter = new RawTextFormatter();
                        break;

                    default:
                        Console.WriteLine("\nFormato inválido! Exibindo em Texto Puro por padrão.");
                        formatter = new RawTextFormatter();
                        break;
                }

         
                formatter.ExibirContatos(contatos);
            }
            catch (Exception ex)
            {
     
                Console.WriteLine($"\nErro ao listar contatos: {ex.Message}");
            }
        }
    }
}
