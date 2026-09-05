using System;
using BibliotecaMatriz;

class Exercicio_2 {
    static int MenorValor(int[,] matriz) {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int menor = matriz[0, 0];
        for(int i = 0; i < linhas; i++) {
            for(int j = 0; j < colunas; j++) {
                if(matriz[i, j] < menor)
                    menor = matriz[i, j];
            }
        } 
        return menor; 
    }
    static void Main() {
        int linhas, colunas;
        Console.Write("\nDigite o numero de linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero de colunas: ");
        colunas = int.Parse(Console.ReadLine());

       
        int[,] matriz = new int[linhas, colunas];
        Matriz.GerarMatriz(matriz);
        Console.WriteLine();
        Matriz.MostrarMatriz(matriz);

        
        Console.WriteLine($"\nMenor valor da Matriz: {MenorValor(matriz)}");
        Console.ReadKey();

    }
}
