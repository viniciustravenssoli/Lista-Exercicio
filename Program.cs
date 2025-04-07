using System;
using System.Globalization;

namespace SistemaAlunos;


class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE GESTÃO ===");
        Console.WriteLine("1 - Sistema de Alunos");
        Console.WriteLine("2 - Sistema de Funcionários");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            SistemaAlunos();
        }
        else if (opcao == "2")
        {
            SistemaFuncionarios();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    // Sistema de Alunos
    static void SistemaAlunos()
    {
        List<Aluno> alunos = new List<Aluno>();

        Console.WriteLine("=== Cadastro de Alunos ===");
        while (true)
        {
            Console.Write("Nome (ou 'fim' para encerrar): ");
            string nome = Console.ReadLine();
            if (nome.ToLower() == "fim") break;

            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            alunos.Add(new Aluno(nome, n1, n2, n3));
            Console.WriteLine();
        }

        Console.WriteLine("=== RELATÓRIO DE ALUNOS ===");
        int aprovados = 0;
        double somaMedias = 0;

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno.ExibirResultado());
            somaMedias += aluno.CalcularMedia();
            if (aluno.Aprovado()) aprovados++;
        }

        int total = alunos.Count;
        Console.WriteLine("--- RESUMO ---");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Aprovados: {aprovados}");
        Console.WriteLine($"Reprovados: {total - aprovados}");
        Console.WriteLine($"Média geral: {(total > 0 ? somaMedias / total : 0):F1}");
    }

    // Sistema de Funcionários
    static void SistemaFuncionarios()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        Console.WriteLine("=== Cadastro de Funcionários ===");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Funcionário #{i}");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Horas Trabalhadas: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor da Hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionarios.Add(new Funcionario(nome, horas, valorHora));
        }

        Console.WriteLine("=== FOLHA DE PAGAMENTO ===");

        foreach (var f in funcionarios)
        {
            Console.WriteLine(f.ExibirFolhaPagamento());
        }
    }
}

