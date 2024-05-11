//  Suma dos matrices de diferentes tamaños. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir dos matrices de diferentes tamaños
        int[,] matriz1 = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] matriz2 = {
            { 7, 8, 9},
            { 10, 11,12 }
        };

        // Obtener las dimensiones de ambas matrices
        int filasMatriz1 = matriz1.GetLength(0);
        int columnasMatriz1 = matriz1.GetLength(1);
        int filasMatriz2 = matriz2.GetLength(0);
        int columnasMatriz2 = matriz2.GetLength(1);

        // Verificar si las dimensiones son compatibles
        if (filasMatriz1 != filasMatriz2 || columnasMatriz1 != columnasMatriz2)
        {
            Console.WriteLine("No se pueden sumar las matrices porque tienen tamaños diferentes.");
            return;
        }

        // Sumar las matrices
        int[,] matrizSuma = new int[filasMatriz1, columnasMatriz1];
        for (int i = 0; i < filasMatriz1; i++)
        {
            for (int j = 0; j < columnasMatriz1; j++)
            {
                matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Imprimir la matriz suma
        Console.WriteLine("La matriz suma es:");
        for (int i = 0; i < filasMatriz1; i++)
        {
            for (int j = 0; j < columnasMatriz1; j++)
            {
                Console.Write(matrizSuma[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

