using System;

namespace Q9_Array
{
    public class ProgramQ9Array
    {
     
        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }
        }

        public static void Executar()
        {
            Produto[] produtos = new Produto[5]; 
            int contador = 0; 

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
                        if (contador >= 5)
                        {
                            Console.WriteLine("\nLimite de produtos atingido! Não é possível cadastrar mais produtos.");
                        }
                        else
                        {
                            Produto produto = new Produto();

                            Console.Write("\nDigite o nome do produto: ");
                            produto.Nome = Console.ReadLine();

                            Console.Write("Digite a quantidade em estoque: ");
                            produto.Quantidade = int.Parse(Console.ReadLine());

                            Console.Write("Digite o preço unitário: ");
                            produto.Preco = decimal.Parse(Console.ReadLine());

                            produtos[contador] = produto;
                            contador++;

                            Console.WriteLine("\nProduto cadastrado com sucesso!");
                        }
                        break;

                    case "2":
                        if (contador == 0)
                        {
                            Console.WriteLine("\nNenhum produto cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("\n=== Produtos Cadastrados ===");
                            for (int i = 0; i < contador; i++)
                            {
                                Produto p = produtos[i];
                                Console.WriteLine($"Produto: {p.Nome} | Quantidade: {p.Quantidade} | Preço: R$ {p.Preco:F2}");
                            }
                        }
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
    }
}
