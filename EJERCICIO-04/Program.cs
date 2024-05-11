// Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        ImprimirPiramideNumerosInvertida(5); // Puedes cambiar el número aquí
    }

    static void ImprimirPiramideNumerosInvertida(int n, int filaActual = 1)
    {
        if (filaActual > n)
            return;

        ImprimirFilaInvertida(n, filaActual);
        Console.WriteLine();

        ImprimirPiramideNumerosInvertida(n, filaActual + 1);
    }

    static void ImprimirFilaInvertida(int n, int filaActual)
    {
        if (filaActual == 0)
            return;

        Console.Write(filaActual + " ");
        ImprimirFilaInvertida(n, filaActual - 1);
    }
}

