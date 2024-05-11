// Multiplica una matriz por un número. 

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

        // Definir el número por el cual multiplicar la matriz
        int multiplicador = 2;

        // Multiplicar la matriz por el multiplicador
        int[,] matrizResultado = MultiplicarMatrizPorNumero(matriz, multiplicador);

        // Imprimir la matriz resultante
        ImprimirMatriz(matrizResultado);
    }

    static int[,] MultiplicarMatrizPorNumero(int[,] matriz, int numero)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int[,] matrizResultado = new int[filas, columnas];

        // Multiplicar cada elemento de la matriz por el número
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizResultado[i, j] = matriz[i, j] * numero;
            }
        }

        return matrizResultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        Console.WriteLine("Matriz Resultado:");
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

