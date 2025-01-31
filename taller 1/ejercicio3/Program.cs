using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar la cantidad de números a promediar
        Console.WriteLine("Ingresa la cantidad de números a promediar:");
        int n;

        // Validar que la entrada sea un número válido y mayor que 0
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Entrada no válida. Ingresa un número entero mayor que 0:");
        }

        double suma = 0;

        // Solicitar los números y calcular la suma
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ingresa el número {i + 1}:");
            double numero;

            // Validar que la entrada sea un número válido
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada no válida. Ingresa un número:");
            }

            suma += numero;
        }

        // Calcular y mostrar el promedio
        double promedio = suma / n;
        Console.WriteLine($"El promedio de los {n} números ingresados es: {promedio:F2}");
    }
}