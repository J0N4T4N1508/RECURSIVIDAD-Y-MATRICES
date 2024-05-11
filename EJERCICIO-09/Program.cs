// Accede al elemento central de una matriz. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[,] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Obtener las dimensiones de la matriz
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Determinar el elemento central
        int filaCentral = filas / 2;
        int columnaCentral = columnas / 2;

        // Acceder al elemento central
        int elementoCentral = matriz[filaCentral, columnaCentral];

        // Imprimir el elemento central
        Console.WriteLine("El elemento central de la matriz es: " + elementoCentral);
    }
}


