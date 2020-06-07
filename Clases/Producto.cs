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

    public class Producto

    {
        public Fecha FechaCaducidad { get; set; }
        public uint NumeroLote { get; set; }
        public Fecha FechaEnvasado { get; set; }
        public PaisOrigenEnum PaisOrigen { get; set; }

        public Producto(
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen)
        {
            this.FechaCaducidad = fechaCaducidad;
            this.NumeroLote = numeroLote;
            this.FechaEnvasado = fechaEnvasado;
            this.PaisOrigen = paisOrigen;
        }
    }
}
