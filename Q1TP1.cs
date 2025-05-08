using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1TP1
{

    delegate double CalculateDiscount(double inputPrecoOriginal);

    public class ProgramQ1TP1
    {

        private static double calculaDiscontoMethod(double inputPrecoOriginal)
        {
            double precoCalculado = (inputPrecoOriginal * 0.9);

            Console.WriteLine($"\nO valor do produto com disconto sera: {precoCalculado}");

            return precoCalculado;

        }

        public static void Executar()
        {

            double inputPrecoOriginal = 0;
            Console.Clear();
            Console.WriteLine("Questão 1: Implementação de Delegate Personalizado para Descontos");
       
            Console.WriteLine("\nPor favor, informe o preço original do produto.");
            try
            {
                inputPrecoOriginal = Double.Parse(Console.ReadLine());
                CalculateDiscount calculaDisconto = calculaDiscontoMethod;

                calculaDisconto(inputPrecoOriginal);

            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: formato inválido. Isso não é um número.");

            }

            Console.ReadKey(); 
        }
    }
}

