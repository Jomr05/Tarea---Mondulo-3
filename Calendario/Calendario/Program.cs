using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime fechaActual = DateTime.Now;

            
            DateTime primerDiaMes = new DateTime(fechaActual.Year, fechaActual.Month, 1);

            
            int diaSemanaInicio = (int)primerDiaMes.DayOfWeek;

            // número de días en el mes actual
            int diasEnMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);

            // nombre del mes en español
            string nombreMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(fechaActual.Month);

            // Mostrar el encabezado con el mes y el año
            Console.WriteLine($"     {nombreMes.ToUpper()} {fechaActual.Year}");
            Console.WriteLine("Lun Mar Mié Jue Vie Sáb Dom");

            
            for (int i = 0; i < (diaSemanaInicio == 0 ? 6 : diaSemanaInicio - 1); i++)
            {
                Console.Write("    ");
            }

            
            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                Console.Write($"{dia,3} ");

                // Saltar a la siguiente línea al llegar a domingo
                if ((dia + (diaSemanaInicio == 0 ? 6 : diaSemanaInicio - 1)) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
