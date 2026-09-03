using System;
using BibliotecaMatriz;
class AulaMatriz {
    static void Main() {
         Console.Write("Digite o número de linhas da matriz: ");
        int linhas = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de colunas da matriz: ");
        int colunas = int.Parse(Console.ReadLine());

        // declare a matriz
        int[,] matriz = new int[linhas, colunas];

        // Testando a função leia
        Console.WriteLine("\nDigite os elementos da matriz:");
        Matriz.LerMatriz(matriz);
        Console.WriteLine("\nMatriz digitada:");
        Matriz.MostrarMatriz(matriz);
        Console.ReadKey();

        // Testando a função gera
        Console.WriteLine("\nGerando uma matriz com valores aleatórios...");
        Matriz.GerarMatriz(matriz);
        Console.WriteLine("\nMatriz gerada aleatoriamente:");
        Matriz.MostrarMatriz(matriz);
        Console.ReadKey();

        


    }
}