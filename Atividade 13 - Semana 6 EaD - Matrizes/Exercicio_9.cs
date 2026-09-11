using System;
using BibliotecaMatriz;
class Exercicio_9 {
    public static void MostrarMatriz (int[,] matriz) {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++) {
                Console.Write($"Região {i + 1}: ");
                for (int j = 0; j < colunas; j++) {
                    Console.Write($"{matriz[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

    static void Main() {
        Console.Write("\nQuantidade de regiões(linhas): ");
        int linhas = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de cidades cidades(colunas): ");
        int colunas = int.Parse(Console.ReadLine());

        int[,] tropas = new int[linhas, colunas];
        Matriz.GerarMatriz(tropas);
        Console.WriteLine();
        Console.WriteLine("Matriz das Tropas (Quantidade de tropas pos cidade): ");
        MostrarMatriz(tropas);
        
        Console.WriteLine("\nForça Total das Regiões: "); 
        for(int i = 0; i < linhas; i++) {
            int somaLinha = 0;
            for(int j = 0; j < colunas; j++) {
                somaLinha += tropas[i, j];
            }
            Console.WriteLine($"Região {i + 1}: {somaLinha}");
        }


        Console.ReadKey();
        


    }
}