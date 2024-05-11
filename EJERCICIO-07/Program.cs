//  Crea una matriz de números complejos. 

using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz de tamaño 2x2 de números complejos
        Complex[,] matriz = new Complex[2, 2];

        // Llenar la matriz con algunos valores
        matriz[0, 0] = new Complex(1, 2);   // 1 + 2i
        matriz[0, 1] = new Complex(3, -4);  // 3 - 4i
        matriz[1, 0] = new Complex(-5, 6);  // -5 + 6i
        matriz[1, 1] = new Complex(7, 8);   // 7 + 8i

        // Imprimir la matriz
        Console.WriteLine("Matriz de números complejos:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

