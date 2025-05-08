using System;
using System.Threading;


namespace Q6TP1
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

    class ProgramQ6TP1
    {
        public static void Executar()
        {
            Logger logger = new Logger();

            Action<string> logConsole, logFile, logDatabase, multiLog;

            logConsole = logger.LogToConsole;

            logFile = logger.LogToFile;

            logDatabase = logger.LogToDatabase;

            multiLog = logConsole + logFile + logDatabase;


            string mensagem = "Esta é uma mensagem de log.";
            Console.WriteLine("\nExecutando o log...");

            multiLog(mensagem);
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
