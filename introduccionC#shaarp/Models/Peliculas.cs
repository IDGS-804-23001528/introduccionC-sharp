using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccionC_shaarp.Models
{
    public class Peliculas
    {
        public string Titulo { get; set; }

        public int Duracion { get; set; }

        public DateTime Publicacion { get; set; }

        public string Pais { get; set; }
    }
}