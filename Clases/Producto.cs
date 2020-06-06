using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Producto
    {
        private Fecha FechaCaducidad { get; set; }
        private uint NumeroLote { get; set; }
        private Fecha FechaEnvasado { get; set; }

        // Enum de países
        private enum PaisOrigen {
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
