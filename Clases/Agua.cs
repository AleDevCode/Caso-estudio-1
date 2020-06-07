using System;
using System.Collections.Generic;
using System.Text;

namespace CasoEstudio1
{
    class Agua
    {
        public float Salinidad { get; set; }
        public float GramosSal { get; set; }
        public float LitrosAgua { get; set; }


        public Agua(float gramosSal, float litrosAgua)
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
