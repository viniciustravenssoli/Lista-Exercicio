public class Funcionario
{
    public string Nome { get; }
    public double HorasTrabalhadas { get; }
    public double ValorHora { get; }

    public Funcionario(string nome, double horasTrabalhadas, double valorHora)
    {
        Nome = nome;
        HorasTrabalhadas = horasTrabalhadas;
        ValorHora = valorHora;
    }

    public double CalcularBruto()
    {
        return HorasTrabalhadas * ValorHora;
    }

    public double CalcularDescontoINSS()
    {
        return CalcularBruto() * 0.08;
    }

    public double CalcularSalarioLiquido()
    {
        return CalcularBruto() - CalcularDescontoINSS();
    }

    public string ExibirFolhaPagamento()
    {
        return
        $@"Funcionário: {Nome}
        Horas Trabalhadas: {HorasTrabalhadas:F1}
        Salário Bruto: R$ {CalcularBruto():F2}
        Desconto INSS (8%): R$ {CalcularDescontoINSS():F2}
        Salário Líquido: R$ {CalcularSalarioLiquido():F2}
        ";
    }
}
