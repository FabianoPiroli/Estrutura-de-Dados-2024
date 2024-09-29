using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tamanho da senha
        int tamanhoSenha = 10;

        // Gerar senha
        string senha = GerarSenha(tamanhoSenha);

        // Exibir senha gerada
        Console.WriteLine("Senha gerada: " + senha);
    }

    static string GerarSenha(int tamanho)
    {
        // Caracteres permitidos na senha
        const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

        // Pilha para armazenar caracteres
        Stack<char> pilha = new Stack<char>();

        // Gerador de números aleatórios
        Random random = new Random();

        // Adicionar caracteres aleatórios à pilha
        for (int i = 0; i < tamanho; i++)
        {
            char caractere = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            pilha.Push(caractere);
        }

        // Fila para armazenar a senha final
        Queue<char> fila = new Queue<char>();

        // Transferir caracteres da pilha para a fila
        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        // Construir a senha final a partir da fila
        char[] senhaArray = fila.ToArray();
        return new string(senhaArray);
    }
}
