using System;
using System.Globalization;

namespace SistemaAlunos;


class Program
{
    static void Main()
    {
        Console.Write("Informe o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Informe a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Aluno aluno = new Aluno(nome, nota1, nota2);
        Console.WriteLine($"\nAluno: {aluno.Nome}");
        Console.WriteLine($"Média: {aluno.CalcularMedia():F2}");
    }
}
