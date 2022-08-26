using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int num;
            Console.Write("Ingrese un número entero para obtener su cuadrado: ");
            entrada = Console.ReadLine();
            try
            {
                num = Int32.Parse(entrada);
                int cuadrado = num * num;
                Console.WriteLine("Resultado: " + cuadrado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Se intenta calcular el cuadrado de algo que no es un número");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
