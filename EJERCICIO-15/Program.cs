// Escribe una función que encuentre el elemento máximo de una matriz. 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz de ejemplo
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Encontrar el elemento máximo
        int maximo = EncontrarMaximoMatriz(matriz);

        // Imprimir el resultado
        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static int EncontrarMaximoMatriz(int[,] matriz)
    {
        int maximo = matriz[0, 0]; // Asumimos que el primer elemento es el máximo inicialmente

        // Recorrer la matriz para encontrar el máximo
        foreach (int elemento in matriz)
        {
            if (elemento > maximo)
            {
                maximo = elemento;
            }
        }

        return maximo;
    }
}

