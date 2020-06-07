using CasoEstudio1.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Agua: Congelado
    {
        public float Salinidad { get; set; }
        public float GramosSal { get; set; }
        public float LitrosAgua { get; set; }




        public Agua(
            float gramosSal, 
            float litrosAgua, 
            Fecha fechaCaducidad, 
            uint numeroLote, 
            Fecha fechaEnvasado, 
            PaisOrigenEnum paisOrigen, 
            string tempMantoRecomendada)
            :base(
                 fechaCaducidad, 
                 numeroLote, 
                 fechaEnvasado, 
                 paisOrigen, 
                 tempMantoRecomendada)
        {
            this.GramosSal = gramosSal;
            this.LitrosAgua = litrosAgua;

            this.Salinidad = this.CalcularSalinidad();
        }


        private float CalcularSalinidad()
        {
            return this.GramosSal / this.LitrosAgua;
        }

    }
}
