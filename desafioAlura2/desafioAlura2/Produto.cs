class Produto
{
    public Estoque Estoque { get; set; }

    public void ExibirEstoque()
    {
        Console.WriteLine($"O produto {Estoque.Nome} contem {Estoque.Quantidade} unidades");
    }
}

class Estoque
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Estoque(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }

    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        produto.Estoque = this;
    }
}