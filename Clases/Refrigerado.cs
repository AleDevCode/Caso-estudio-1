using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Refrigerado: Producto
    {

        public string CodigoOrganismoSupervisionAlimentaria { get; set; }
        public string TemperaturaMantoRecomendada { get; set; }

        public Refrigerado(
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen, 
            string codigoOrgSuperAli, 
            string tempMantoRecomendada) : 
            base(
                fechaCaducidad,
                numeroLote, 
                fechaEnvasado, 
                paisOrigen)
        {
            this.CodigoOrganismoSupervisionAlimentaria = codigoOrgSuperAli;
            this.TemperaturaMantoRecomendada = tempMantoRecomendada;
        }
    }
}
