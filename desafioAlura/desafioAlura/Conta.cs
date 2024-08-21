
class Conta
{
    public Titular Nome { get; set; }
    public int Agencia { get; set; }
    public int NumConta { get; set; }
    public int Saldo { get; set; }
    public int Limite { get; set; }

    public void ExibirInfoDetalhado()
    {      
        Console.WriteLine($"Nome do titular: {Nome.Nome}\n\nAgencia: {Agencia}\t Numero da conta: {NumConta}\t Saldo: {Saldo}\t Limite: {Limite}");
    }
}

class Titular
{
    public string Nome { get; set; }

    public Titular(string nome)
    {
        Nome = nome;
    }
}