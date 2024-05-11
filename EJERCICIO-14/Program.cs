// Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz de tamaño 3x3 (puedes cambiar el tamaño según sea necesario)
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Calcular la media de los elementos de la matriz
        double media = CalcularMediaMatriz(matriz);

        // Calcular la mediana de los elementos de la matriz
        int mediana = CalcularMedianaMatriz(matriz);

        // Calcular la desviación estándar de los elementos de la matriz
        double desviacionEstandar = CalcularDesviacionEstandarMatriz(matriz, media);

        // Imprimir los resultados
        Console.WriteLine("Media: " + media);
        Console.WriteLine("Mediana: " + mediana);
        Console.WriteLine("Desviación Estándar: " + desviacionEstandar);
    }

    static double CalcularMediaMatriz(int[,] matriz)
    {
        int totalElementos = matriz.Length;
        int sumaTotal = 0;

        // Sumar todos los elementos de la matriz
        foreach (int elemento in matriz)
        {
            sumaTotal += elemento;
        }

        // Calcular la media
        double media = (double)sumaTotal / totalElementos;
        return media;
    }

    static int CalcularMedianaMatriz(int[,] matriz)
    {
        int[] elementos = new int[matriz.Length];
        int index = 0;

        // Obtener todos los elementos de la matriz
        foreach (int elemento in matriz)
        {
            elementos[index++] = elemento;
        }

        // Ordenar los elementos
        Array.Sort(elementos);

        // Calcular la mediana
        int n = elementos.Length;
        int mediana;
        if (n % 2 == 0)
        {
            mediana = (elementos[n / 2 - 1] + elementos[n / 2]) / 2;
        }
        else
        {
            mediana = elementos[n / 2];
        }

        return mediana;
    }

    static double CalcularDesviacionEstandarMatriz(int[,] matriz, double media)
    {
        double sumatoriaDiferenciasCuadrado = 0;
        int totalElementos = matriz.Length;

        // Calcular la sumatoria de las diferencias al cuadrado
        foreach (int elemento in matriz)
        {
            sumatoriaDiferenciasCuadrado += Math.Pow(elemento - media, 2);
        }

        // Calcular la desviación estándar
        double desviacionEstandar = Math.Sqrt(sumatoriaDiferenciasCuadrado / totalElementos);
        return desviacionEstandar;
    }
}

