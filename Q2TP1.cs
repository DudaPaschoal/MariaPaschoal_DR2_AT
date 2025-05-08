using System;
using System.Collections.Generic;
using System.IO;

namespace Q2TP1
{ 
    public class ProgramQ2TP1
    {

    static void SaudacaoPortugues(string nome)
    {
        Console.WriteLine($"Olá, {nome}!");
    }

    static void SaudacaoIngles(string nome)
    {
        Console.WriteLine($"Hello, {nome}!");
    }

    static void SaudacaoEspanhol(string nome)
    {
        Console.WriteLine($"¡Hola, {nome}!");
    }

    public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Escolha o idioma da saudação:");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");

            string escolha = Console.ReadLine();
            Action<string> saudacao;

            switch (escolha)
            {
                case "1":
                    saudacao = SaudacaoPortugues;
                    break;
                case "2":
                    saudacao = SaudacaoIngles;
                    break;
                case "3":
                    saudacao = SaudacaoEspanhol;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Saudação em português será usada por padrão.");
                    saudacao = SaudacaoPortugues;
                    break;
            }

            // Executando a saudação escolhida
            saudacao(nome);
            Console.ReadKey();

        }

    }
}
