using System;

public class Operaciones
{
    // Método para concatenar elementos
    public string Concatenar(params object[] elementos) // params permite recibir un número variable de argumentos0.
    {
        if (elementos == null || elementos.Length == 0)
        {
            throw new ArgumentException("Debe proporcionar al menos un elemento para concatenar.");
        }
        return string.Concat(elementos);
    }

    // Método para fraccionar un número
    public double Fraccionar(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
        {
            throw new ArgumentException("El valor proporcionado no puede estar vacío.");
        }

        if (double.TryParse(numero, out double resultado))
        {
            return resultado / 2.0; // Dividir por 2 como ejemplo de fraccionamiento
        }
        else
        {
            throw new ArgumentException("El valor proporcionado no es un número válido.");
        }
    }

    // Método para contar elementos
    public int Contador(params object[] elementos)
    {
        if (elementos == null)
        {
            return 0; // Si no hay elementos, devolver 0
        }
        return elementos.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones(); // Crear una instancia de la clase Operaciones

        try
        {
            // Ejemplo de uso de los métodos
            string concatenacion = operaciones.Concatenar("Hola", " ", "mundo");
            double fraccionado = operaciones.Fraccionar("123,34");
            int contador = operaciones.Contador(1, 3.4, "hola", '3');

            // Imprimir resultados
            Console.WriteLine("Concatenación: " + concatenacion);
            Console.WriteLine("Fraccionado: " + fraccionado);
            Console.WriteLine("Contador: " + contador);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}