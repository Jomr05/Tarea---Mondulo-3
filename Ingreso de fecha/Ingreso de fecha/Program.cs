using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_de_fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, ingresa tu fecha de nacimiento (formato: DD-MM-AAAA):");

            string input = Console.ReadLine();

            // Intentamos convertir la entrada a un objeto DateTime con el formato especificado
            if (DateTime.TryParseExact(input, "dd-MM-yyyy", null, DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                // Configuramos la cultura a español
                CultureInfo culturaEspañol = new CultureInfo("es-ES");

                // Obtenemos el nombre del día de la semana en español
                string diaSemana = culturaEspañol.DateTimeFormat.GetDayName(fechaNacimiento.DayOfWeek);

                // Mostramos el resultado al usuario
                Console.WriteLine($"Naciste un día {diaSemana}.");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida. Asegúrate de usar el formato DD-MM-AAAA.");
            }
            Console.ReadKey();
        }
    }
}
