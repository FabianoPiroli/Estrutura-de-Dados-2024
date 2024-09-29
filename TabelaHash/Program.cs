// Exemplo de uma agenda telefônica

using System.Collections;

Hashtable phoneBook = new Hashtable()
{
    //{ "Chave", "Valor" },
    { "Fabiano", "(49) 99829-1764" },
    { "Mauricio", "(49) 99975-8575" },
    {"Gabriel", "(49) 99105-8904" }
};

// É possível adicionar elementos de diversas formas
// Pelo próprio indicine chane inexistente
phoneBook["Thiago Padilha"] = "(49) 99176-8255";

// OU pelo método Add()
phoneBook.Add("Marcos Henrique", "(49) 99202-6169");

// Entretanto, a tabela hash verifica se há duplocidade de chave e pode lançar uma Exception
try
{
    phoneBook.Add("Mauricio", "(49) 99975-8575");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
    Console.WriteLine(ex.Message);
}

// Percorrendo itens da HashTable
Console.WriteLine("Agenda Tedefônica");
if(phoneBook.Count == 0)
    Console.WriteLine("A agenda está vazia.");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");

