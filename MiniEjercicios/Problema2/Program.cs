using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int dividendo, divisor, resultado;
            Console.WriteLine("--- División de dos números ---");
            Console.Write("Ingrese el dividendo: ");
            entrada = Console.ReadLine();
            while (!Int32.TryParse(entrada, out dividendo))
            {
                Console.WriteLine("Error. Debe ingresar un número válido. Ingrese nuevamente.");
                entrada = Console.ReadLine();
            }

            Console.Write("Ingrese el divisor: ");
            entrada = Console.ReadLine();
            while (!Int32.TryParse(entrada, out divisor))
            {
                Console.WriteLine("Error. Debe ingresar un número válido. Ingrese nuevamente.");
                entrada = Console.ReadLine();
            }
            
            try
            {
                resultado = dividendo / divisor;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error. No se puede dividir por cero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
