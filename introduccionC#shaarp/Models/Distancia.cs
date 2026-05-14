using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccionC_shaarp.Models
{
    public class Distancia
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }

        public double X2 { get; set; }
        public double Y2 { get; set; }

        public double Resultado { get; set; }

        public void CalcularDistancia()
        {
            double restaX = this.X2 - this.X1;
            double restaY = this.Y2 - this.Y1;

            this.Resultado = Math.Sqrt(Math.Pow(restaX, 2) + Math.Pow(restaY, 2));
        }
    }
}