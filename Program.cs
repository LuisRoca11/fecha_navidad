// Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.

using System;

namespace fecha_navidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha (dd/mm)");
            string fecha = Console.ReadLine();
            string navidad = "25/12";

            if (fecha == navidad)
            {
                Console.WriteLine("Esta fecha corresponde a navidad");
            }
            else
            {
                Console.WriteLine("Esta fecha no es navidad");
            }

            Console.ReadKey();
        }
    }
}
