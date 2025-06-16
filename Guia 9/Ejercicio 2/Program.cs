using System;

class ProgramaPrimos
{
    static void Main()
    {
       
        Console.Write("Ingrese el número inicial (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número final (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nNúmeros primos entre {n} y {m}:");

       
        MostrarPrimos(n, m);
    }

   
    static void MostrarPrimos(int actual, int final)
    {
        if (actual > final)
        {
            return; 
        }

        int resultado = EsPrimo(actual, 2); 

        if (resultado == 1)
        {
            Console.WriteLine(actual);
        }

        
        MostrarPrimos(actual + 1, final);
    }

   
    static int EsPrimo(int numero, int divisor)
    {
        if (numero < 2)
        {
            return 0; 
        }

        if (divisor > numero / 2)
        {
            return 1; 
        }

        if (numero % divisor == 0)
        {
            return 0; 
        }

        return EsPrimo(numero, divisor + 1); 
    }
}