// Calcula la media de los elementos de una matriz. 


using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Calcular la media de la matriz
        double media = CalcularMediaMatriz(matriz);

        // Imprimir la media
        Console.WriteLine("La media de los elementos de la matriz es: " + media);
    }

    static double CalcularMediaMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int totalElementos = filas * columnas;
        int sumaTotal = 0;

        // Sumar todos los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                sumaTotal += matriz[i, j];
            }
        }

        // Calcular la media
        double media = (double)sumaTotal / totalElementos;
        return media;
    }
}
