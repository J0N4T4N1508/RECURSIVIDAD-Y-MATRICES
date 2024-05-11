//  Escribe una función que encuentre la matriz de covarianza de dos matrices.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir dos matrices de ejemplo
        double[,] matriz1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double[,] matriz2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        // Calcular la matriz de covarianza
        double[,] matrizCovarianza = CalcularMatrizCovarianza(matriz1, matriz2);

        // Imprimir la matriz de covarianza
        ImprimirMatriz(matrizCovarianza);
    }

    static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);

        // Verificar si las matrices tienen las mismas dimensiones
        if (filas != matriz2.GetLength(0) || columnas != matriz2.GetLength(1))
        {
            throw new ArgumentException("Las matrices deben tener las mismas dimensiones.");
        }

        // Calcular la media de cada conjunto de datos
        double mediaMatriz1 = CalcularMedia(matriz1);
        double mediaMatriz2 = CalcularMedia(matriz2);

        // Calcular la covarianza entre los elementos de las dos matrices
        double covarianza = 0;
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                covarianza += (matriz1[i, j] - mediaMatriz1) * (matriz2[i, j] - mediaMatriz2);
            }
        }

        // Calcular la matriz de covarianza
        double factor = 1.0 / (filas * columnas);
        double[,] matrizCovarianza = new double[2, 2];
        matrizCovarianza[0, 0] = factor * covarianza;
        matrizCovarianza[0, 1] = factor * covarianza;
        matrizCovarianza[1, 0] = factor * covarianza;
        matrizCovarianza[1, 1] = factor * covarianza;

        return matrizCovarianza;
    }

    static double CalcularMedia(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double suma = 0;

        // Calcular la suma de todos los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        // Calcular la media
        return suma / (filas * columnas);
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Matriz de covarianza:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

