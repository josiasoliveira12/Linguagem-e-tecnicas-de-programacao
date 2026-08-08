using System;

class Exercicio_1 {
     static void GerarVetor(int[] vetor) {
        Random aleatorio = new Random();
        for(int i = 0; i < vetor.Length; i++)
            vetor[i] = aleatorio.Next(1, 100);
        
    }
     static void MostrarVetor(int[] vetor) {
        Console.WriteLine();
        Console.WriteLine("Dados do Vetor: ");
        for(int i = 0; i < vetor.Length; i++) {
            Console.Write(vetor[i] + " | ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static int SomarVetor(int[] vetor) {
        int soma = 0;
        for(int i = 0; i < vetor.Length; i++) {
            soma += vetor[i];
        }
        return soma;
    }
    static void Main() {
        int n, resultadoSoma;
        Console.WriteLine("Qual o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        GerarVetor(vetor);
        MostrarVetor(vetor);
        resultadoSoma = SomarVetor(vetor);
        Console.WriteLine($"Soma dos elementos do vetor: {resultadoSoma}");
        
    }
    
}

