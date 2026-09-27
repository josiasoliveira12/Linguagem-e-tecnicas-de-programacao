using System;
using System.Runtime.InteropServices.Marshalling;
using BibliotecaMatriz;
class Exercicio_8 {
    static void Main() {
        int linhas = 501;
        int colunas = 501;
        int cont = 0;
        int[,] matrizRaios = new int[linhas, colunas];

        Console.Write("\nQuantidade de raios registrados: ");
        int qtdRaios = int.Parse(Console.ReadLine());

        for(int i = 1; i <= qtdRaios; i++) {
            Console.Write($"Cordenadas do raio {i}: ");
            string[] entrada = Console.ReadLine().Split(" ");
            int indiceLinha = int.Parse(entrada[0]);
            int indiceColuna = int.Parse(entrada[1]);
            matrizRaios[indiceLinha, indiceColuna]++;
            if(matrizRaios[indiceLinha, indiceColuna] > 1)
                cont = 1;
        }
        Console.WriteLine(cont);

        



    }
}