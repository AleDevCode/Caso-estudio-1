using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Aire: Congelado
    {
        public ComposicionAire ComposicionAireCongelado { get; set; }

        public Aire(
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen, 
            string tempMantoRecomendada, 
            ComposicionAire compAire) 
            : base(
                  fechaCaducidad, 
                  numeroLote, 
                  fechaEnvasado, 
                  paisOrigen, 
                  tempMantoRecomendada)
        {
            this.ComposicionAireCongelado = compAire; 
        }
    }
}
