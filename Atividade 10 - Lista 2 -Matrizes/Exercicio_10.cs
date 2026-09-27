using System;
using BibliotecaMatriz;

class Exercicio_10 {
    static long CalcularArea(int[,] retangulos) {
        int n = retangulos.GetLength(0);

        int[] xs = new int[n * 2];
        int[] ys = new int[n * 2];

        for (int i = 0; i < n; i++) {
            xs[i * 2] = retangulos[i, 0];
            xs[i * 2 + 1] = retangulos[i, 2];

            ys[i * 2] = retangulos[i, 1];
            ys[i * 2 + 1] = retangulos[i, 3];
        }

        Array.Sort(xs);
        Array.Sort(ys);

        long area = 0;

        for (int i = 0; i < xs.Length - 1; i++) {
            for (int j = 0; j < ys.Length - 1; j++){
                double px = (xs[i] + xs[i + 1]) / 2.0;
                double py = (ys[j] + ys[j + 1]) / 2.0;

                bool dentro = false;

                for (int k = 0; k < n; k++) {
                    if (px >= retangulos[k, 0] &&
                        px < retangulos[k, 2] &&
                        py >= retangulos[k, 1] &&
                        py < retangulos[k, 3])
                    {
                        dentro = true;
                        break;
                    }
                }

                if (dentro) {
                    long largura = xs[i + 1] - xs[i];
                    long altura = ys[j + 1] - ys[j];

                    area += largura * altura;
                }
            }
        }

        return area;
    }

    static void Main() {
        Console.Write("Quantidade de retângulos: ");
        int n = int.Parse(Console.ReadLine());

        int[,] retangulos = new int[n, 4];

        Matriz.lerMatriz(retangulos);

        long area = CalcularArea(retangulos);

        Console.WriteLine($"Área total: {area}");
    }
}