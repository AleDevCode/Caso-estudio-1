using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Congelado: Producto
    {
        public string TemperaturaMantoRecomendada { get; set; }
        public Congelado(
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen, 
            string tempMantoRecomendada)
            :base(
                 fechaCaducidad, 
                 numeroLote, 
                 fechaEnvasado, 
                 paisOrigen)
        {
            this.TemperaturaMantoRecomendada = tempMantoRecomendada;

        }
    }
}
