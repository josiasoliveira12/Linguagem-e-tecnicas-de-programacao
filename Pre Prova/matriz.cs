using System;
using BibliotecaMatriz;

class matriz{
	
	static double CalcularPorcentual(int[,] matriz){
		int linhas = matriz.GetLength(0);
		int colunas = matriz.GetLength(1);
		double porcentagem = 0;
		
		for(int i = 0; i < linhas; i++){
			for(int j = 0; j < colunas; j++){
				if(matriz[i, j] == 0){
					porcentagem++;
				}
			}
		}
		porcentagem = (porcentagem * 100) / 36;
		
		return porcentagem;
	}
	
	static void HouveAumento(double anterior, double atual){
		if(atual > anterior)
			Console.WriteLine($"\nHouve Aumento no Desmatamento – Anterior {anterior:f2}% -> Atual {atual:f2}%");
		else
			Console.WriteLine($"\nNão Houve Aumento no Desmatamento – Anterior {anterior:f2}% -> {atual:f2}%");
	}
	
	
	
	static void Main(){
		int[,] matriz6meses = Matriz.carregarMatriz("dados_matriz_6meses_atras.csv");
		int[,] matrizAtual = Matriz.carregarMatriz("dados_matriz_atual.csv");
		
		Console.WriteLine("\nMatriz 6 meses atras: ");
		Matriz.mostrarMatriz(matriz6meses);
		Console.WriteLine("\nMatriz Atual: ");
		Matriz.mostrarMatriz(matrizAtual);
		
		double porcent6meses = CalcularPorcentual(matriz6meses);
		double porcentAtual = CalcularPorcentual(matrizAtual);
		
		Console.WriteLine("\nPorcentual de ocorrencias na matriz 6 meses atras: ");
		Console.WriteLine($"Área Desmatada (Código 0): {porcent6meses:f2}");
		Console.WriteLine("\nPorcentual de ocorrencias na Matriz Atual: ");
		Console.WriteLine($"Área Desmatada (Código 0): {porcentAtual:f2}");
		HouveAumento(porcent6meses, porcentAtual);
		
		
		
		
	}
}
