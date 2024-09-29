using System.Collections;


Dictionary<string, string> produtos = new Dictionary<string, string>()
{
    {"7891011250729", "A1" },
    {"7891011250710", "A1" },
    {"7891011250734", "A1" },
    {"7891011250789", "A1" },
    {"7891011250775", "A1" },

    {"7891011250706", "A3" },
    {"7891011234991", "A3" },
    {"7891011242347", "A3" },
    {"7891011743283", "A3" },
    {"7891011908324", "A3" },

    {"7891011673242", "B6" },
    {"7891011243792", "B6" },
    {"7891432344232", "B6" },
    {"7834243432467", "B6" },
    {"7891568765433", "B6" },

    {"7891011243454", "C9" },
    {"7891023457904", "C9" },
    {"7891032453795", "C9" },
    {"7891013457903", "C9" },
    {"7893534745674", "C9" }

};

while(true)
{
    Console.WriteLine("Digite ou escaneie o código de barras: \nCaso queira parar digite 'sair'.");
    string? codigobarras = Console.ReadLine();

    if(codigobarras?.ToLower() == "sair")
    break;

    if( produtos.TryGetValue(codigobarras!, out string? local))
    {
        Console.WriteLine($"O produto está na prateleira: {local}");

    }
    else
    {
        Console.WriteLine("Código inválido, verifique-o e tente novamente!");
    }
};
