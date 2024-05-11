// Crea una matriz de números reales. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz de tamaño 3x3 de números reales
        double[,] matriz = new double[3, 3];

        // Llenar la matriz con algunos valores
        matriz[0, 0] = 1.1;
        matriz[0, 1] = 2.2;
        matriz[0, 2] = 3.3;
        matriz[1, 0] = 4.4;
        matriz[1, 1] = 5.5;
        matriz[1, 2] = 6.6;
        matriz[2, 0] = 7.7;
        matriz[2, 1] = 8.8;
        matriz[2, 2] = 9.9;

        // Imprimir la matriz
        Console.WriteLine("Matriz de números reales:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

