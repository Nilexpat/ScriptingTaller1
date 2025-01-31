using System;


internal class Program
{
    private static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese una frase
        Console.WriteLine("Ingresa una frase de mínimo 3 palabras:");
        string entrada = Console.ReadLine() ?? string.Empty;

        // Verificar si la entrada tiene al menos 3 palabras
        string[] palabras = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (palabras.Length < 3)
        {
            Console.WriteLine("La frase debe tener al menos 3 palabras. Intenta de nuevo.");
            return; // Salir del programa si no cumple el requisito
        }

        // Procesar cada palabra
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i];

            // Verificar que la palabra no esté vacía (por si hay múltiples espacios)
            if (!string.IsNullOrEmpty(palabra))
            {
                // Convertir la primera letra a mayúscula y el resto a minúscula                 Ejemlplo: "hOLA" -> "Hola"
                string primeraLetra = palabra.Substring(0, 1).ToUpper();  // H
                string restoDePalabra = palabra.Substring(1).ToLower();   // ola
                string nuevaPalabra = primeraLetra + restoDePalabra;      // Hola

                // Imprimir la palabra formateada
                Console.Write(nuevaPalabra + " ");  // Hola + espacio
            }
        }

        // Salto de línea al final para mejor formato
        Console.WriteLine();
    }
}