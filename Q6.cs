using System;

namespace Q6
{

    public class Aluno
    {
  
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double MediaNotas { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("=== Dados do Aluno ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média das Notas: {MediaNotas:F2}");
            Console.WriteLine($"Situação: {VerificarAprovacao()}");
        }

        public string VerificarAprovacao()
        {
            return MediaNotas >= 7 ? "Aprovado" : "Reprovado";
        }
    }

    public class ProgramQ6
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("Questão 6: Cadastro de Alunos");

      
            Aluno aluno = new Aluno
            {
                Nome = "Maria Paschoal",
                Matricula = "20250001",
                Curso = "Análise e Desenvolvimento de Sistemas",
                MediaNotas = 8.5
            };

          
            aluno.ExibirDados();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }
}
