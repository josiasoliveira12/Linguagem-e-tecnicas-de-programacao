using System;
using BibliotecaMatriz;
class Exercicio_5 {
    static int AcharNumero(int[,] matriz, int x) {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int cont = 0;
        for(int i = 0; i < linhas; i++) {
            for(int j = 0; j < colunas; j++) {
                if(matriz[i, j] == x) 
                    cont++;
                
            }
        }
        return cont;
    }
    static void Main() {
        int linhas, colunas, num, cont;
        Console.Write("\nNumero de Linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Numero de Colunas: ");
        colunas = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero para verificar: ");
        num = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        Matriz.gerarMatriz(matriz);
        Console.WriteLine("\nMatriz Gerada!");
        Matriz.mostrarMatriz(matriz);

        cont = AcharNumero(matriz, num);
        if(cont > 0) 
            Console.WriteLine($"\nO numero {num} aparece {cont} vezes na matriz!!");
        else
            Console.WriteLine($"\nO numero {num} nao aparece na matriz!");
        Console.ReadKey();
    }
}