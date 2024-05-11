//  Crea una matriz de matrices. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz de matrices de enteros
        int[][,] matrizDeMatrices = new int[2][,];

        // Llenar la matriz con algunas matrices
        matrizDeMatrices[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        matrizDeMatrices[1] = new int[3, 3] { { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        // Imprimir la matriz de matrices
        Console.WriteLine("Matriz de matrices:");
        for (int i = 0; i < matrizDeMatrices.Length; i++)
        {
            Console.WriteLine($"Matriz {i + 1}:");
            for (int j = 0; j < matrizDeMatrices[i].GetLength(0); j++)
            {
                for (int k = 0; k < matrizDeMatrices[i].GetLength(1); k++)
                {
                    Console.Write(matrizDeMatrices[i][j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

