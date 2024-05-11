// Escribe una función recursiva que imprima la tabla de multiplicar del n. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 5; // Puedes cambiar el número aquí
        ImprimirTablaMultiplicar(n);
    }

    static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
    {
        if (multiplicador > 12) // Imprimimos hasta 12 multiplicaciones
            return;

        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");

        ImprimirTablaMultiplicar(n, multiplicador + 1);
    }
}





