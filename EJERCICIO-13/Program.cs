// Crea una matriz de números aleatorios de tamaño 100x100. 


using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Random para generar números aleatorios
        Random rnd = new Random();

        // Definir el tamaño de la matriz
        int filas = 100;
        int columnas = 100;

        // Crear una matriz de tamaño 100x100
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con números aleatorios
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.Next(1, 101); // Generar números aleatorios entre 1 y 100
            }
        }

        // Imprimir la matriz (opcional)
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        // Solo imprimiremos los primeros 10x10 elementos para no saturar la consola
        int maxFilas = Math.Min(filas, 10);
        int maxColumnas = Math.Min(columnas, 10);

        Console.WriteLine("Matriz de números aleatorios (primeros 10x10 elementos):");
        for (int i = 0; i < maxFilas; i++)
        {
            for (int j = 0; j < maxColumnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

