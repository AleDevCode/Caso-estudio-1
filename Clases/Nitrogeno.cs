using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Nitrogeno: Congelado
    {
        public string MetodoCongelacion { get; set; }
        public uint TiempoExposicionNitrogeno { get; set; }

        public Nitrogeno(
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen, 
            string tempMantoRecomendada, 
            string metodoCongelacion, 
            uint tiempoExpo) 
            : base(
                  fechaCaducidad, 
                  numeroLote, 
                  fechaEnvasado, 
                  paisOrigen, 
                  tempMantoRecomendada)
        {
            this.MetodoCongelacion = metodoCongelacion;
            this.TiempoExposicionNitrogeno = tiempoExpo;
        }
    }
}
