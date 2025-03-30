using System;

namespace Q7
{

    public class ContaBancaria
    {
        public string Titular { get; set; }

        private decimal Saldo;

    
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            else if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
        }

        
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }

  
    public class ProgramQ7
    {
        public static void Executar()
        {
            Console.Clear(); 
            Console.WriteLine("Questão 7: Banco Digital (Encapsulamento)");

            
            ContaBancaria conta = new ContaBancaria
            {
                Titular = "Maria Paschoal"
            };

            Console.WriteLine($"\nTitular: {conta.Titular}");

          
            conta.Depositar(500);     
            conta.ExibirSaldo();      

            conta.Sacar(700);        
            conta.ExibirSaldo();     

            conta.Sacar(200);         
            conta.ExibirSaldo();     

            conta.Depositar(-50);     

           
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
