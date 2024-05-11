// Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100. 



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Los números pares del 1 al 100 son:");
        ImprimirPares(1);
    }

    static void ImprimirPares(int numero)
    {
        if (numero <= 100)
        {
            if (numero % 2 == 0)
            {
                Console.Write(numero + " ");
            }
            ImprimirPares(numero + 1); // Llamada recursiva para el siguiente número
        }
    }
}
