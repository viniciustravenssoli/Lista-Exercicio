public class Aluno
{
    public string Nome { get; }
    public double Nota1 { get; }
    public double Nota2 { get; }
    public double Nota3 { get; }

    public Aluno(string nome, double nota1, double nota2, double nota3)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    }

    public double CalcularMedia()
    {
        return Math.Round((Nota1 + Nota2 + Nota3) / 3, 1);
    }

    public bool Aprovado()
    {
        double media = CalcularMedia();
        return media >= 7.0 && Nota1 >= 5.0 && Nota2 >= 5.0 && Nota3 >= 5.0;
    }

    public string ExibirResultado()
    {
        string status = Aprovado() ? "Aprovado" : "Reprovado";
        return $"{Nome} - Média: {CalcularMedia():F1} - {status}";
    }
}
