using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz de tamaño 3x3
        int[,] matriz = new int[3, 3] {
            { -1, 2, -3 },
            { 6, -8, 9 },
            { -3, 4, -5 }
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        // Recorrer la matriz y reemplazar los valores negativos
        for (int i = 0; i < matriz.GetLength(0); i++)  // getLength(0) obtiene el número de filas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // getLength(1) obtiene el número de columnas 
            {
                if (matriz[i, j] < 0)
                {
                    matriz[i, j] = Math.Abs(matriz[i, j]); // Tomar el valor absoluto
                }
            }
        }

        Console.WriteLine("\nMatriz con valores negativos reemplazados:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t"); // \t es un tabulador
            }
            Console.WriteLine();
        }
    }
}