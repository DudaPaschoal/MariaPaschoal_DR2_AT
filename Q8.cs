using System;

namespace Q8
{
 
    public class Funcionario
    {
  
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        
        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }


        public void ExibirDados()
        {
            Console.WriteLine("\n=== Dados do Funcionário ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: R$ {CalcularSalario():F2}");
        }
    }

   
    public class Gerente : Funcionario
    {
      
        public override decimal CalcularSalario()
        {
            return SalarioBase * 1.2m; 
        }
    }

    public class ProgramQ8
    {
        public static void Executar()
        {
            Console.Clear(); 
            Console.WriteLine("Questão 8: Cadastro de Funcionários (Herança)");

           
            Funcionario funcionario = new Funcionario
            {
                Nome = "Carlos Lobato",
                Cargo = "Desenvolvedor",
                SalarioBase = 5000.00m
            };

            Gerente gerente = new Gerente
            {
                Nome = "Dora Maria",
                Cargo = "Gerente de Projetos",
                SalarioBase = 8000.00m
            };


            funcionario.ExibirDados();
            gerente.ExibirDados();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
