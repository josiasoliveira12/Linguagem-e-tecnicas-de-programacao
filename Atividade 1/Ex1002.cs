using System;
class Program {
    static void Main() {
        double area, n, raio;
        n = 3.14159;
        raio = double.Parse(Console.ReadLine());
        area = n * (raio * raio);
        Console.WriteLine($"A={area:f4}");

    }
}

