// Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        ImprimirNúmeroPirámide(5); // Puedes cambiar el número aquí
    }

    static void ImprimirNúmeroPirámide(int n, int filaActual = 1)
    {
        if (filaActual > n)
            return;

        ImprimirFila(n, filaActual);
        Console.WriteLine();

        ImprimirNúmeroPirámide(n, filaActual + 1);
    }

    static void ImprimirFila(int n, int filaActual)
    {
        if (filaActual == 0)
            return;

        ImprimirFila(n, filaActual - 1);
        Console.Write(filaActual + " ");
    }
}

