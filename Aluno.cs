public class Aluno
{
    public string Nome { get; }
    public double Nota1 { get; }
    public double Nota2 { get; }

    public Aluno(string nome, double nota1, double nota2)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public double CalcularMedia()
    {
        return (Nota1 + Nota2) / 2;
    }
}