using System;
using System.Collections.Generic;
using System.IO;

namespace Q4TP1
{
    class TemperatureSensor
    {
        public delegate void TemperatureExceededHandler(double temperature);

        public event TemperatureExceededHandler TemperatureExceeded;

        public void LerTemperature(double temperature)
        {
            Console.WriteLine($"Temperatura lida: {temperature}ºC");

            if (temperature > 100)
            {
                TemperatureExceeded?.Invoke(temperature);
            }
        }
    }

    class ProgramQ4TP1
    {
        public static void Executar()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += AlertaTemperatura;

            Console.WriteLine("Simulação de sensor de temperatura. Digite 'sair' para encerrar.");

            while (true)
            {
                Console.Write("\nDigite a temperatura lida: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                    break;

                if (double.TryParse(entrada, out double temp))
                {
                    sensor.LerTemperature(temp);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido ou 'sair'.");
                }
            }

            Console.WriteLine("\nEncerrando o programa.");
        }

        static void AlertaTemperatura(double temperatura)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ALERTA: Temperatura excedida! ({temperatura}ºC)");
            Console.ResetColor();
        }
    }

}
