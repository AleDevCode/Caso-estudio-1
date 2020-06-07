using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    public class Producto
    {
        public Fecha FechaCaducidad { get; set; }
        public uint NumeroLote { get; set; }
        public Fecha FechaEnvasado { get; set; }

        // Enum de países
        public enum PaisOrigen {
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
    }
}
