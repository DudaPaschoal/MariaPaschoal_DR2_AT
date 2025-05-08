using System;
using System.Threading;


namespace Q5TP1
{
    class DownloadManager
    {
        public delegate void DownloadCompletedHandler(object sender, EventArgs e);

        public event DownloadCompletedHandler DownloadCompleted;

        public void StartDownload(string arquivo)
        {
            Console.WriteLine($"Iniciando download de: {arquivo}...");

            Thread.Sleep(3000); // 3 segundos 

            OnDownloadCompleted();
        }

        protected virtual void OnDownloadCompleted()
        {
            DownloadCompleted.Invoke(this, EventArgs.Empty);
        }
    }

    class ProgramQ5TP1
    {
        public static void Executar()
        {
            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += ExibirMensagemConclusao;

            Console.Write("Digite o nome do arquivo para download: ");
            string nomeArquivo = Console.ReadLine();

            manager.StartDownload(nomeArquivo);

            Console.WriteLine("\nPressione qualquer tecla para encerrar o programa...");
            Console.ReadKey();
        }

        static void ExibirMensagemConclusao(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Download concluído com sucesso!");
            Console.ResetColor();
        }

    }
}
