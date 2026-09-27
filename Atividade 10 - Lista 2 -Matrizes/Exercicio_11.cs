using System;
using BibliotecaMatriz;
class Exercicio_11 {
    static int SomarDiagonalPrincial(int[,] matriz) {
        int linhas = matriz.GetLength(0);
        int soma = 0;
        for(int i = 0; i < linhas; i++) {
            soma += matriz[i, i];
        }
        return soma;
    }

    static int SomarDiagonalSecubdaria(int[,] matriz) {
        int linhas = matriz.GetLength(0);
        int soma = 0;
        for (int i = 0; i < linhas; i++){
            soma += matriz[i, linhas - 1 - i];
        }
        return soma;
    }
    static void Main() {
        int linhas, colunas;
        Console.Write("\nNumero de linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("numero de colunas: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] mapaTesouro = new int[linhas, colunas];

        Matriz.gerarMatriz(mapaTesouro);

        Console.WriteLine("\nMapa do tesouro(Quantidade de moedas por região:)");
        Matriz.mostrarMatriz(mapaTesouro);
        Console.WriteLine();
        int somaPrincipal = SomarDiagonalPrincial(mapaTesouro);
        int somaSecundaria = SomarDiagonalSecubdaria(mapaTesouro);
        Console.WriteLine($"Soma da diagonal Principal: {somaPrincipal}");
        Console.WriteLine($"Soma da diagonal secundaria: {somaSecundaria}");

        Console.WriteLine();

        if(somaPrincipal > somaSecundaria)
            Console.WriteLine("O maior tesouro esta na diagonal principal, Vamos para lá!!");
        else
            Console.WriteLine("O maior tesouro esta na diagonal secundaria, Vamos para lá!!");
        
        Console.ReadKey();

    }
    
}