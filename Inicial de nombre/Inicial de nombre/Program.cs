using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicial_de_nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                char inicial = nombre.Trim()[0];
                Console.WriteLine($"La inicial de tu nombre es: {inicial}");
            }
            else
            {
                Console.WriteLine("No ingresaste un nombre válido.");
            }
            Console.ReadKey();
        }
    }
}
