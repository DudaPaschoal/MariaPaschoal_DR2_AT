using System;
using System.Threading;


namespace Q7TP1
{
    class Logger
    {
        public void LogToConsole(string mensagem)
        {
            Console.WriteLine($"[Console] {mensagem}");
        }

        public void LogToFile(string mensagem)
        {
            string filePath = "log.txt";
            File.AppendAllText(filePath, $"[File] {mensagem}\n");
            Console.WriteLine($"[File] Mensagem gravada em {filePath}");
        }

        public void LogToDatabase(string mensagem)
        {
            Console.WriteLine($"[Database] Mensagem registrada no banco de dados: {mensagem}");
        }
    }

    class ProgramQ7TP1
    {
        public static void Executar()
        {
            Logger logger = new Logger();

            Action<string> logActions = null;
            logActions?.Invoke("Mensagem teste sem handlers."); // Nada deve acontecer, sem exceção


            logActions += logger.LogToConsole;
            logActions += logger.LogToFile;
            logActions += logger.LogToDatabase;

            string mensagem = "Esta é uma mensagem de log.";
            Console.WriteLine("\nExecutando o log...");
            logActions?.Invoke(mensagem);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
