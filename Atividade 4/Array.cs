using System;
class Array {
    static void lerVetor(int[] vetor) {
        Console.WriteLine();
        Console.WriteLine("Entre com os dados do vetor: ");
        for(int i = 0; i < vetor.Length; i++) {
            Console.Write($"Vetor na posiçao {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }
    static void gerarVetor(int[] vetor) {
        Random aleatorio = new Random();
        for(int i = 0; i < vetor.Length; i++)
            vetor[i] = aleatorio.Next(1, 100);
        
    }
    static void mostrarVetor(int [] vetor) {
        Console.WriteLine();
        Console.WriteLine("Dados do Vetor: ");
        for(int i = 0; i < vetor.Length; i++) {
            Console.Write(vetor[i] + " | ");
        }
    }
    static void Main() {
        int[] vetor = new int[5];
        gerarVetor(vetor);
        mostrarVetor(vetor);
    }
}

