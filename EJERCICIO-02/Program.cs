// Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.

using System.Runtime.InteropServices.ObjectiveC;

class program 
{
    static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine($"La suma de los numeros del 1 al {n} son:");
        int resultado = ImprimirSuma(5);
        Console.WriteLine(resultado);
    }

    static int ImprimirSuma(int n) 
    {
        if(n == 1) 
        {
            return 1;
        }
        else 
        {
            return n + ImprimirSuma(n - 1);  
        }
    }
}

