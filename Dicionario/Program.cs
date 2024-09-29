// Diferente da tabela Hash o Dictionary nos permite especificar o tipo de dado que será utilizado nos pares
// Key -> Value
// Isso nos formece uma estrutura fortemente tipada

using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using Dicionario;
using System.Collections;
using System.Collections.Generic;

Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
    {"Chave 1", "Valor 1"},
    {"Chave 2", "Valor 2"},
};

// Obter valor do Dictionary
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}catch (Exception ex)
{
    Console.WriteLine("Erro ao obter valor de Chave 3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar para evitar erros e prejuizos de execução
if(dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: {dictionary ["Chave 2"]}");
}

// Outra forma de eu ter o valor e evitar erros
dictionary.TryGetValue("Chave 4", out string? valor);
if(valor is not null)
    Console.WriteLine($"Chave 4: {valor}");

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "valor 0";

// E também percorrer o dicionário
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

//Utilizando tipos Abstratos de Dados com Dicionário

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add(1, new Pessoa(){Id = 0, BirthDate = DateTime(1998, 8, 11), Name = "Fabiano Piroli"});
dicPessoa.Add(1, new Pessoa(){Id = 1, BirthDate = DateTime(2004, 11, 14), Name = "Luis Eduardo"});

foreach(KeyValuePair<int, Pessoa> kvp in dictionary)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}
