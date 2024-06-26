﻿// Escribe una función que encuentre la submatriz de mayor suma de una matriz. 
using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir una matriz de ejemplo
        int[,] matriz = {
            { 1, 2, -1, 4 },
            { -3, 5, 2, -6 },
            { 7, -8, 9, 10 },
            { -11, 12, 13, 14 }
        };

        // Encontrar la submatriz de mayor suma
        int sumaMaxima = 0;
        int filaInicio = 0, filaFin = 0, columnaInicio = 0, columnaFin = 0;

        EncontrarSubmatrizMayorSuma(matriz, out sumaMaxima, out filaInicio, out filaFin, out columnaInicio, out columnaFin);

        // Imprimir la submatriz de mayor suma y su suma
        Console.WriteLine("Submatriz de mayor suma:");
        for (int i = filaInicio; i <= filaFin; i++)
        {
            for (int j = columnaInicio; j <= columnaFin; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Suma máxima: " + sumaMaxima);
    }

    static void EncontrarSubmatrizMayorSuma(int[,] matriz, out int sumaMaxima, out int filaInicio, out int filaFin, out int columnaInicio, out int columnaFin)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        sumaMaxima = int.MinValue;
        filaInicio = filaFin = columnaInicio = columnaFin = -1;

        for (int izquierda = 0; izquierda < columnas; izquierda++)
        {
            int[] sumaTemp = new int[filas];

            for (int derecha = izquierda; derecha < columnas; derecha++)
            {
                for (int i = 0; i < filas; i++)
                {
                    sumaTemp[i] += matriz[i, derecha];
                }

                int sumaActual = 0;
                int filaInicioTemp = 0;

                for (int i = 0; i < filas; i++)
                {
                    if (sumaActual + sumaTemp[i] > sumaTemp[i])
                    {
                        sumaActual += sumaTemp[i];
                    }
                    else
                    {
                        sumaActual = sumaTemp[i];
                        filaInicioTemp = i;
                    }

                    if (sumaActual > sumaMaxima)
                    {
                        sumaMaxima = sumaActual;
                        filaInicio = filaInicioTemp;
                        filaFin = i;
                        columnaInicio = izquierda;
                        columnaFin = derecha;
                    }
                }
            }
        }
    }
}


