using System;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double kilometros, litros;
            Console.Write("Ingrese la cantidad de kilometros recorridos: ");
            entrada = Console.ReadLine();
            while (!Double.TryParse(entrada, out kilometros))
            {
                Console.WriteLine("Error. Debe ingresar un número válido. Ingrese nuevamente.");
                entrada = Console.ReadLine();
            }

            Console.Write("Ingrese la cantidad de litros gastados: ");
            entrada = Console.ReadLine();
            while (!Double.TryParse(entrada, out litros))
            {
                Console.WriteLine("Error. Debe ingresar un número válido. Ingrese nuevamente.");
                entrada = Console.ReadLine();
            }
            
            try
            {
                double resultado = kilometros / litros;
                // Corregir cuando se ingresa 0 por divisor
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
