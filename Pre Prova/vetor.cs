using System;
using BibliotecaVetor;
class vetor{
	
	static double MediaRoubos(int[] roubos){
		double media = 0.0;
		for(int i = 0; i < roubos.Length; i++){
			media += roubos[i];
		}
		media = media / roubos.Length;
		return media;
	}
	static void Top3(string[] bairros, int[] roubos){
		int top1 = int.MinValue, indice1 = 0;
		int top2 = int.MinValue, indice2 = 0;
		int top3 = int.MinValue, indice3 = 0;
		
		for(int i = 0; i < roubos.Length; i++){
			if(top1 < roubos[i]){
				top1 = roubos[i];
				indice1 = i;
			}
		}
		for(int i = 0; i < roubos.Length; i++){
			if(top2 < roubos[i] && i != indice1){
				top2 = roubos[i];
				indice2 = i;
			}
		}
		for(int i = 0; i < roubos.Length; i++){
			if(top3 < roubos[i] && i != indice1 && i != indice2){
				top3 = roubos[i];
				indice3 = i;
			}
		}
		Console.WriteLine("\n\n-------TOP 3 BAIRROS MAIS VIOLENTOS---------\n");
		
		Console.WriteLine($"1º Lugar: {bairros[indice1]} (Índice {indice1}) - {top1} roubos");
		Console.WriteLine($"2º Lugar: {bairros[indice2]} (Índice {indice2}) - {top2} roubos");
		Console.WriteLine($"3º Lugar: {bairros[indice3]} (Índice {indice3}) - {top3} roubos");
	}
	static void Main(){
		string[] bairros = {"Centro", 
						  "Moema", 
						  "Pinheiros", 
						  "Itaquera", 
						  "Tatuape", 
						  "Santo Amaro", 
						  "Vila Mariana", 
						  "Lapa", 
						  "Capão Redondo",
						  "Santana"};
						  
		int[] VetorRoubo = new int[10];
		
		Vetor.gerarVetor(VetorRoubo);
		Console.WriteLine();
		Vetor.mostrarVetor(VetorRoubo);
		Console.Write($"\n\nMedia de roubos: {MediaRoubos(VetorRoubo):f1}");
		Top3(bairros, VetorRoubo);
		
		
		Console.ReadKey();
	}
}