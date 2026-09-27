using System;
using BibliotecaMatriz;
class Exercicio_3 {
    static void Main() {
        int linhas, colunas;
        Console.Write("\nNumero de Linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Numeros de Colunas: ");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.WriteLine("\nDiagonal Principal: ");
        for(int i = 0; i < linhas; i++) {
            for(int j = 0; j < colunas; j++) {
                if(i == j) {
                    Console.Write($"{matriz[i, j], 3}");
                }else{
                    Console.Write("   ");
                }
            }

        Console.WriteLine();
        }
    Console.ReadKey();

    }
}