using System;

class ProgramaFactorial
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nFactoriales desde 0 hasta {n}:");

       
        MostrarFactoriales(0, n);
    }

    
    static void MostrarFactoriales(int i, int n)
    {
        if (i > n)
        {
            return; 
        }

        int resultado = CalcularFactorial(i);
        Console.WriteLine($"{i}! = {resultado}");

        MostrarFactoriales(i + 1, n); 
    }

    
    static int CalcularFactorial(int numero)
    {
        if (numero == 0)
        {
            return 1; 
        }

        return numero * CalcularFactorial(numero - 1); 
    }
}