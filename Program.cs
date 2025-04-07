using System;
using System.Globalization;

namespace SistemaAlunos;


class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        Console.WriteLine("Cadastro de Alunos (Digite 'parar' para encerrar):\n");

        while (true)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            if (nome.ToLower() == "parar") break;

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            alunos.Add(new Aluno(nome, nota1, nota2, nota3));

            Console.WriteLine();
        }

        Console.WriteLine("\n--- RELATÓRIO ---\n");

        int aprovados = 0;
        int reprovados = 0;
        double somaMedias = 0;

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno.ExibirResultado());

            somaMedias += aluno.CalcularMedia();
            if (aluno.Aprovado())
                aprovados++;
            else
                reprovados++;
        }

        int total = alunos.Count;
        double mediaGeral = total > 0 ? somaMedias / total : 0;

        Console.WriteLine(" RESUMO ");
        Console.WriteLine($"Total de alunos: {total}");
        Console.WriteLine($"Aprovados: {aprovados}");
        Console.WriteLine($"Reprovados: {reprovados}");
        Console.WriteLine($"Média geral da turma: {mediaGeral:F1}");
    }
}

