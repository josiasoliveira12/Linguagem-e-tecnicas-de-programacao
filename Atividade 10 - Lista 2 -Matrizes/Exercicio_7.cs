using System;
using BibliotecaMatriz;
class Exercicio_7 {
    static int[,] SomarMatriz(int[,] matrizA, int[,] matrizB) {
        int linhas = matrizA.GetLength(0);
        int colunas = matrizA.GetLength(1);

        int[,] soma = new int[linhas, colunas];

        for(int i = 0; i < linhas; i++) {
            for(int j = 0; j < colunas; j++) {
                soma[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }
        return soma;
    }
    static void Main() {
        int linhas = 0;
        int colunas = 0;

        do{

        Console.Write("Numero de Linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Numero de Colunas: ");
        colunas = int.Parse(Console.ReadLine());

        if(linhas != colunas)
            Console.WriteLine("\nEntre com valores validos(linhas == colunas)\n");

        }while(linhas != colunas);

        int[,] matrizA = new int[linhas, colunas];
        int[,] matrizB = new int[linhas, colunas];
        
        
        Matriz.gerarMatriz(matrizA);
        Matriz.gerarMatriz(matrizB);
        Console.WriteLine("\nMatriz A: ");
        Matriz.mostrarMatriz(matrizA);
        Console.WriteLine("\nMatriz B: ");
        Matriz.mostrarMatriz(matrizB);

        Console.WriteLine("\nSoma Das Matrizes: ");
        int[,] soma = SomarMatriz(matrizA, matrizB);
        Matriz.mostrarMatriz(soma);
        
    }
}