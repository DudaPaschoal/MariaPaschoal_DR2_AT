using System;
using System.Collections.Generic;
using System.IO;

namespace Q3TP1
{ 
    public class ProgramQ3TP1
    {

    

    static void Resultado(double resultadoCalculo)
    {
        Console.WriteLine($"O resultado do calculo foi de {resultadoCalculo}!");
    }

    public static void Executar()
        {

            try
            {
                Console.Write("Por favor, insira a base de um retangulo ");
                double baseRetangulo = Double.Parse(Console.ReadLine());

                Console.Write("Agora, insira a altura do retangulo ");
                double altura = Double.Parse(Console.ReadLine());


                Func<double, double, double> calcularArea = (largura, altura) => largura * altura;

                double area = calcularArea(baseRetangulo, altura);

                Action<double> actionCalculoArea = Resultado;


                actionCalculoArea(area);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: formato inválido. Isso não é um número.");

            }

            Console.ReadKey();

        }

    }
}
