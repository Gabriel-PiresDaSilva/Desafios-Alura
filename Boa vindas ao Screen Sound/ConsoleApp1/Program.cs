string boasVindas = "Boa vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Linkin Park" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 7, 9 });
bandasRegistradas.Add("The Beatles", new List<int>());


void ExibirLogo()
{
    //@ antes do texto é chamado de vervbtim literal. 
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(boasVindas);
}


void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEcolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEcolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            MostrarBandasRegistradas();
            break;

        case 3:
            AvaliarUmaBanda();
            break;

        case 4:
            ExibirMedia();
            break;

        case -1:
            Console.WriteLine("Até mais");
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");

    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrarda com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nosss aplicação");


    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");       
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda {listaDasBandas[i]}");
    //    Console.WriteLine("Digite uma tecla para volta ao menu principal");
    //    Console.ReadKey();
    //    Console.Clear();
    //    ExibirOpcoesDoMenu();
    //}
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void AvaliarUmaBanda()
{
    // Digite qual banda deseja avaliar 
    // se a banda existir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal.

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja availiar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir media da banda");
    Console.WriteLine("Digite o nome da banda que deseja exibir a media: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA media da banda {nomeDaBanda} é  {notasDaBanda.Average()} .");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

ExibirOpcoesDoMenu();


//-----------------------------------------------------------------------------------------------//

//int nota = 6;
//string musica = "Yesterday";
//if (nota <= 6)
//{
//    Console.WriteLine(musica + " -> essa música não é tão boa");
//}
//else
//{
//    Console.WriteLine(musica + " -> essa música é ótima");
//}


//-----------------------------------------------------------------------------------------------//

//int notaMedia = 5; 

//if (notaMedia >= 5)
//{
//    Console.WriteLine("Nota suficiente para aprovação");
//}
//else
//{
//    Console.WriteLine("Nota insuficiente!");
//}


//-----------------------------------------------------------------------------------------------//

//List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };

//string[] linguagem = new string[] {"C#","Java","JavaScript","Pyton"};

//Console.WriteLine(linguagens[1]);

//-----------------------------------------------------------------------------------------------//



//Random aleatorio = new Random();
//int numeroSecreto =  aleatorio.Next(1, 100);

//do
//{
//    Console.WriteLine("Digite um numero entre 1 a 100"); 
//    int chute = int.Parse(Console.ReadLine());

//    if (chute == numeroSecreto)
//    {
//        Console.WriteLine("Você acertou o numero!!");
//        break;
//    }
//    else if (chute < numeroSecreto) 
//    {
//        Console.WriteLine("O numero é maior");
//    }
//    else
//    {
//        Console.WriteLine("O numero é menor");
//    }
//}while (true);

//Console.WriteLine("O jogo acabou. Você acertou o número secreto!");

//-----------------------------------------------------------------------------------------------//

//int a = 4;
//int b = 2;

//void ExibirQuatroOperacoes() 
//{
//    float soma = a + b;
//    float subtracao = a - b;
//    float divisao = a / b;
//    float multiplicacao = a * b;

//    Console.WriteLine($"a + b = {soma}");
//    Console.WriteLine($"a - b = {subtracao}");
//    Console.WriteLine($"a / b = {divisao}");
//    Console.WriteLine($"a * b = {multiplicacao}");
//}

//ExibirQuatroOperacoes();



//-----------------------------------------------------------------------------------------------//


//List<string> bandas = new List<string>();

//bandas.Add("The Beatles");
//bandas.Add("Pink Floyd");
//bandas.Add("U2");
//bandas.Add("Ira!");

//for (int i = 0; i < bandas.Count; i++)
//{
//    Console.WriteLine(bandas[i]);
//}

//-----------------------------------------------------------------------------------------------//

//List<double> numeros = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
//double soma = 0;

//foreach (double numero in numeros)
//{
//    soma += numero;
//}

//double media = soma / numeros.Count;
//Console.WriteLine($"A média dos elementos da lista é: {media}");

//-----------------------------------------------------------------------------------------------//

//int numero = 5;

//Console.WriteLine($"Tabuada do {numero}:");

//for (int i = 1; i <= 10; i++)
//{
//    int resultado = numero * i;
//    Console.WriteLine($"{numero} x {i} = {resultado}");
//}


//-----------------------------------------------------------------------------------------------//

//double numero1 = 5;
//double numero2 = 4;
//char operacao = '+';

//double resultado = 0;

//switch (operacao)
//{
//    case '+':
//        resultado = numero1 + numero2;
//        break;
//    case '-':
//        resultado = numero1 - numero2;
//        break;
//    case '*':
//        resultado = numero1 * numero2;
//        break;
//    case '/':
//        resultado = numero1 / numero2;
//        break;
//    default:
//        Console.WriteLine("Operação inválida.");
//        return;
//}

//Console.WriteLine($"Resultado da operação: {resultado}");


//var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>>
//{
//    { "Ana", new Dictionary<string, List<int>>
//        {
//            {"C#", new List<int> { 8, 7, 6 } },

//            {"Java", new List<int> { 7, 6, 5 } },

//            {"Python", new List<int> { 9, 8, 8 } }
//        }
//    },

//    { "Maria", new Dictionary<string, List<int>>
//        {
//            {"C#", new List<int> { 6, 5, 4 } },

//            {"Java", new List<int> { 8, 7, 6 } },

//            {"Python", new List<int> { 6, 10, 5 } }
//        }
//    },

//    { "Luiza", new Dictionary<string, List<int>>
//        {
//            { "C#", new List<int> { 2, 3, 10 } },

//            { "Java", new List<int> { 8, 8, 8 } },

//            { "Python", new List<int> { 7, 7, 7 } }
//        }
//    }
//};

//List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
//double mediaMariaEmPython = notasPythonMaria.Average();
//Console.WriteLine(mediaMariaEmPython);


//--------------------------------------------------------------------------------------


//Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

//// Adicione notas para alguns alunos
//notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
//notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

//foreach (var aluno in notasAlunos)
//{
//    double soma = 0;
//    for (int i = 0; i < aluno.Value.Count; i++)
//    {
//        soma += aluno.Value[i];
//    }
//    double media = soma / aluno.Value.Count;
//    Console.WriteLine($"Média de {aluno.Key}: {media}");
//}

//// Simplificado. 
//foreach (var aluno in notasAlunos)
//{
//    double media = aluno.Value.Average();
//    Console.WriteLine($"Média de {aluno.Key}: {media}");
//}

//--------------------------------------------------------------------------------------------------

//Dictionary<string, int> estoque = new Dictionary<string, int>
//{
//    { "camisetas", 50 },
//    { "calças", 30 },
//    { "tênis", 20 },
//    // Adicione mais produtos conforme necessário
//};

//string produto = "camisetas";

//if (estoque.ContainsKey(produto))
//{
//    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
//}
//else
//{
//    Console.WriteLine("Produto não encontrado no estoque.");
//}

//--------------------------------------------------------------------------------------------------


//Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
//{
//    { "Qual é a capital do Brasil?", "Brasília" },
//    { "Quanto é 7 vezes 8?", "56" },
//    { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
//    // Adicione mais perguntas e respostas conforme necessário
//};

//int pontuacao = 0;

//foreach (var pergunta in perguntasERespostas)
//{
//    Console.WriteLine(pergunta.Key);
//    Console.Write("Sua resposta: ");
//    string respostaUsuario = Console.ReadLine()!;

//    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
//    {
//        Console.WriteLine("Correto!\n");
//        pontuacao++;
//    }
//    else
//    {
//        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
//    }
//}

//Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");

//------------------------------------------------------------------------------------------

//Dictionary<string, string> usuarios = new Dictionary<string, string>
//{
//    { "user1", "senha123" },
//    { "user2", "abc456" },
//    // Adicione mais usuários conforme necessário
//};

//string nomeUsuario = "user1";
//string senha = "senha123";

//if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
//    Console.WriteLine("Login bem-sucedido!");
//else
//    Console.WriteLine("Nome de usuário ou senha incorretos.");

//---------------------------------------------------------------------------------------------------


//Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
//};

//foreach (var vendas in vendasCarros)
//{
//    double media = vendas.Value.Average();
//    Console.WriteLine($"a media do {vendas.Key} é {media}");
//}


-----------------------------------------------------------------------------------------------------

