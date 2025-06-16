using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadTerminos;

            
            Console.Write("Ingrese la cantidad de términos de Fibonacci que desea generar (iterativo): ");
            while (!int.TryParse(Console.ReadLine(), out cantidadTerminos) || cantidadTerminos < 0)
            {
                Console.Write("Entrada inválida. Por favor, ingrese un número entero no negativo: ");
            }

            if (cantidadTerminos == 0)
            {
                Console.WriteLine("La serie de Fibonacci para 0 términos es: (vacía)");
                return;
            }

            Console.Write("La serie de Fibonacci (iterativa) para " + cantidadTerminos + " términos es: ");

            long valorActual = 0;
            long valorAnterior = 0;
            long valorAnteriorAnterior = 0; 

            
            for (int contadorTerminos = 0; contadorTerminos < cantidadTerminos; contadorTerminos++)
            {
                
                if (contadorTerminos == 0)
                {
                    
                    valorActual = 0;
                }
                else if (contadorTerminos == 1)
                {
                 
                    valorActual = 1;
                   
                    valorAnterior = valorActual;
                    valorAnteriorAnterior = 0; 
                }
                else
                {
                   
                    valorActual = valorAnterior + valorAnteriorAnterior;
                    
                    valorAnteriorAnterior = valorAnterior;
                    valorAnterior = valorActual;
                }

               
                Console.Write(valorActual);
                if (contadorTerminos < cantidadTerminos - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }


        public static void ImplementacionRecursiva()
        {
            int cantidadTerminos;

            
            Console.Write("Ingrese la cantidad de términos de Fibonacci que desea generar (recursivo): ");
            while (!int.TryParse(Console.ReadLine(), out cantidadTerminos) || cantidadTerminos < 0)
            {
                Console.Write("Entrada inválida. Por favor, ingrese un número entero no negativo: ");
            }

            if (cantidadTerminos == 0)
            {
                Console.WriteLine("La serie de Fibonacci para 0 términos es: (vacía)");
                return;
            }

            Console.Write("La serie de Fibonacci (recursiva) para " + cantidadTerminos + " términos es: ");

            
            for (int i = 0; i < cantidadTerminos; i++)
            {
               
                long fibTerm = CalcularTerminoFibonacciRecursivo(i);
                Console.Write(fibTerm);
                if (i < cantidadTerminos - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        
        public static long CalcularTerminoFibonacciRecursivo(int n)
        {
            if (n == 0)
            {
              
                return 0;
            }
            else if (n == 1)
            {
               
                return 1;
            }
            else
            {
               
                return CalcularTerminoFibonacciRecursivo(n - 1) + CalcularTerminoFibonacciRecursivo(n - 2);
            }
        }
    }
}
