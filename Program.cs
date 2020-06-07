using CasoEstudio1.Clases;
using System;

namespace CasoEstudio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Fecha caducidad = new Fecha();
            caducidad.Anio = 2020;
            caducidad.Mes = 10;
            caducidad.Dia = 30;

            Congelado c = new Congelado();

            Console.WriteLine(c.FechaCaducidad);
           
        }
    }
}
