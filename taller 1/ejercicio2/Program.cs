using System;

class Program
{
    static void Main(string[] args)
    {
        int filas, columnas;

        // Solicitar el número de filas de la matriz con validación
        Console.WriteLine("Ingresa el número de filas de la matriz:");
        while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
        {
            Console.WriteLine("Entrada inválida. Ingresa un número entero positivo para las filas:");
        }

        // Solicitar el número de columnas de la matriz con validación
        Console.WriteLine("Ingresa el número de columnas de la matriz:");
        while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
        {
            Console.WriteLine("Entrada inválida. Ingresa un número entero positivo para las columnas:");
        }

        // Crear la matriz con las dimensiones especificadas
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con valores ingresados por el usuario
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.WriteLine($"Ingresa el elemento ({i + 1}, {j + 1}):");
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.WriteLine("Entrada inválida. Ingresa un número entero:");
                }
            }
        }

        // Calcular y mostrar el promedio de cada fila
        Console.WriteLine("\nEl promedio de cada fila es:");
        for (int i = 0; i < filas; i++)
        {
            double sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }
            double promedioFila = sumaFila / columnas;
            Console.WriteLine($"Fila {i + 1}: {promedioFila:F2}");
        }

        // Calcular y mostrar el promedio de cada columna
        Console.WriteLine("\nEl promedio de cada columna es:");
        for (int j = 0; j < columnas; j++)
        {
            double sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }
            double promedioColumna = sumaColumna / filas;
            Console.WriteLine($"Columna {j + 1}: {promedioColumna:F2}");
        }
    }
}
