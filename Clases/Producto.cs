using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    public enum PaisOrigenEnum
    {
        Argentina,
        Belice,
        Bolivia,
        Brasil,
        Canadá,
        Chile,
        Colombia,
        Cuba,
        Ecuador,
        EstadosUnidos,
        México,
        Paraguay,
        Perú,
        Venezuela

    }

    class Producto
    {
        public Fecha FechaCaducidad { get; set; }
        public uint NumeroLote { get; set; }
        public Fecha FechaEnvasado { get; set; }

        // Enum de países
       
        public PaisOrigenEnum PaisOrigen { get; set; }
    
 
    }
}
