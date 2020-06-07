using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Fresco: Producto
    {

        public Fresco(
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen)
            :base(
                 fechaCaducidad, 
                 numeroLote, 
                 fechaEnvasado, 
                 paisOrigen)
        {
           
        }
    }
}
