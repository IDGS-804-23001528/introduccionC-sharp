using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccionC_shaarp.Models
{
    public class Multiplicacion
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Resultado { get; set; }

        public String Proceso { get; set; }

        public void CalcularMultiplicacion()
        {
            this.Resultado = 0;
            this.Proceso = "";
            for (int i = 0; i < this.Num2; i++)
            {
                this.Resultado = this.Resultado + this.Num1;
                this.Proceso = this.Proceso + this.Num1.ToString();

                if (i < this.Num2 - 1)
                {
                    this.Proceso = this.Proceso + " + ";
                }
            }
            this.Proceso = this.Proceso + " = " + this.Resultado.ToString();
        }
    }
}