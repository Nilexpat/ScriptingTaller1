using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar el número de filas y columnas de la matriz
        Console.WriteLine("Ingresa el número de filas de la matriz:");
        int filas = int.TryParse(Console.ReadLine());

        Console.WriteLine("Ingresa el número de columnas de la matriz:");
        int columnas = int.TryParse(Console.ReadLine());

        // Crear la matriz con las dimensiones especificadas
        
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con valores ingresados por el usuario
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.WriteLine($"Ingresa el elemento ({i + 1}, {j + 1}):");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Calcular y mostrar el promedio de cada fila
        Console.WriteLine("El promedio de cada fila es:");
        for (int i = 0; i < filas; i++)
        {
            double sumaFila = 0;
            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
            }
            double promedioFila = sumaFila / columnas;
            Console.WriteLine($"Fila {i + 1}: {promedioFila:F2}"); // Formato de 2 decimales
        }

        // Calcular y mostrar el promedio de cada columna
        Console.WriteLine("El promedio de cada columna es:");
        for (int j = 0; j < columnas; j++)
        {
            double sumaColumna = 0;
            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }
            double promedioColumna = sumaColumna / filas;
            Console.WriteLine($"Columna {j + 1}: {promedioColumna:F2}"); // Formato de 2 decimales
        }
    }
}
