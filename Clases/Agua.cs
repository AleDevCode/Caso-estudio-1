using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Agua: Congelado
    {
        private float Salinidad { get; set; }
        private float GramosSal { get; set; }
        private float LitrosAgua { get; set; }


        public Agua(float gramosSal, float litrosAgua)
        {
            this.GramosSal = gramosSal;
            this.LitrosAgua = litrosAgua;

            this.Salinidad = this.CalcularSalinidad();
        }


        public float CalcularSalinidad()
        {
            return this.GramosSal / this.LitrosAgua;
        }

    }
}
