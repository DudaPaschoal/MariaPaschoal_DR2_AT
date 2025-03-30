using System;
using System.IO;

namespace Q9_File
{
    public class ProgramQ9File
    {
        public static void Executar()
        {
            string caminhoArquivo = "estoque.txt";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Controle de Estoque");
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirProduto(caminhoArquivo);
                        break;

                    case "2":
                        ListarProdutos(caminhoArquivo);
                        break;

                    case "3":
                        Console.WriteLine("\nEncerrando o programa...");
                        return;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void InserirProduto(string caminhoArquivo)
        {
            using (StreamWriter sw = File.AppendText(caminhoArquivo))
            {
                try
                {
                    Console.Write("\nDigite o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Digite o preço unitário: ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                   
                    sw.WriteLine($"{nome},{quantidade},{preco:F2}");
                    Console.WriteLine("\nProduto cadastrado com sucesso!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nErro: Entrada inválida! Certifique-se de digitar os valores corretamente.");
                }
            }
        }

        private static void ListarProdutos(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
            {
      
                File.Create(caminhoArquivo).Close();
            }

            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string linha;
                bool temProdutos = false;

                while ((linha = sr.ReadLine()) != null)
                {
                    temProdutos = true;
                    try
                    {
                        string[] dados = linha.Split(',');
                        string nome = dados[0];
                        int quantidade = int.Parse(dados[1]);
                        decimal preco = decimal.Parse(dados[2]);

                 
                        Console.WriteLine($"Produto: {nome} | Quantidade: {quantidade} | Preço: R$ {preco:F2}");
                    }
                    catch (Exception)
                    {
                       
                        Console.WriteLine("\nErro ao ler os dados do arquivo. Verifique o formato das entradas.");
                    }
                }

                if (!temProdutos)
                {
                    Console.WriteLine("\nNenhum produto cadastrado.");
                }
            }
        }
    }
}
