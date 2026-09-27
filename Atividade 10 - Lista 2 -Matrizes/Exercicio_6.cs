using System;
using System.Diagnostics;
using BibliotecaMatriz;
class Exercicio_6 {
    public static void MostrarMatrizDouble (double[,] matriz) {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write($"{matriz[i, j],6:F2}| ");
                }
                Console.WriteLine();
            }
        }
        public static void GerarMatrizDouble(double[,] matriz) {
            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = random.NextDouble() * 100;
        }
        public static double[,] SubtrairMatriz(double[,] matrizA, double[,] matrizB) {
            int linhas = matrizA.GetLength(0);
            int colunas = matrizA.GetLength(1);
            double[,] subtrair = new double[linhas, colunas];
                for(int i = 0; i < linhas; i++) {
                    for(int j = 0; j < colunas; j++) {
                         subtrair[i, j] = matrizB[i, j] - matrizA[i, j];
                    }
                }
            return subtrair;
        }
        public static double[,] SomarMatriz(double[,] matrizA, double[,] matrizB) {
            int linhas = matrizA.GetLength(0);
            int colunas = matrizA.GetLength(1);
            double[,] soma = new double[linhas, colunas];
                for(int i = 0; i < linhas; i++) {
                    for(int j = 0; j < colunas; j++) {
                         soma[i, j] = matrizA[i, j] + matrizB[i, j];
                    }
                }
            return soma;
        }
    static void Main() {
        int linhas, colunas;
        char opcao;
        Console.Write("\nNumero de linhas da Matriz: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Numero de colunas da Matriz: ");
        colunas = int.Parse(Console.ReadLine());

        double[,] matriz_A = new double[linhas, colunas]; 
        double[,] matriz_B = new double[linhas, colunas]; 

        GerarMatrizDouble(matriz_A);
        GerarMatrizDouble(matriz_B);

        Console.WriteLine("\nMatrize A: "); 
        MostrarMatrizDouble(matriz_A);
        Console.WriteLine("\nMatrize B: "); 
        MostrarMatrizDouble(matriz_B);

        do{
        Console.WriteLine("\n---MENU DE OPÇÕES---\n");
        Console.WriteLine("(A) somar as duas matrizes.");
        Console.WriteLine("(B) subtrair a primeira matriz da segunda.");
        Console.WriteLine("(C) adicionar uma constante as duas matrizes.");
        Console.WriteLine("(D) imprimir as matrizes.");
        Console.WriteLine("(E) sair.");
        Console.Write("\nQual opção deseja: ");
        opcao = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (opcao) {
                case 'A':

                    Console.WriteLine("\nSoma das Matrizes.");
                    double[,] soma = SomarMatriz(matriz_A, matriz_B);
                    MostrarMatrizDouble(soma);
                    Console.WriteLine("-------------------------------------------------------------------");

                break;  
                case 'B':

                    Console.WriteLine("\nSubtração das Matrizes.");
                    double[,] subtrair = SubtrairMatriz(matriz_A, matriz_B);
                    MostrarMatrizDouble(subtrair);
                    Console.WriteLine("-------------------------------------------------------------------");
                    
                break; 
                case 'C':

                    Console.WriteLine("\nAdicionar uma constente.");
                    Console.Write("Digite a constante: ");
                    double constante = double.Parse(Console.ReadLine());
                    for(int i = 0; i < linhas; i++) {
                        for(int j = 0; j < colunas; j++) {
                            matriz_A[i, j] += constante;
                            matriz_B[i, j] += constante;
                        }
                    }

                break; 
                case 'D':

                    Console.WriteLine("\nImprimir as matrizes.");
                    Console.WriteLine("\nMatriz A: ");
                    MostrarMatrizDouble(matriz_A);
                    Console.WriteLine("\nMatriz B: ");
                    MostrarMatrizDouble(matriz_B);
                    Console.WriteLine("-----------------------------------------------------------------");

                break;
                case 'E':
                    Console.WriteLine("\nSaindooo....");

                break;

            default:
                Console.WriteLine("Opção invalida");
            break;
            }
        }while(opcao != 'E');
    }
}