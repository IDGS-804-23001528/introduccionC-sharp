using introduccionC_shaarp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccionC_shaarp.Service
{
    public class PeliculasService
    {

        public List<Peliculas> ObtenerPelicula()

        {

            var pelicula1 = new Peliculas()

            {

                Titulo = "Superman",

                Duracion = 120,

                Pais = "USA",

                Publicacion = new DateTime(2013, 12, 5)

            };


            var pelicula2 = new Peliculas()

            {

                Titulo = "Spiderman",

                Duracion = 111,

                Pais = "USA",

                Publicacion = new DateTime(2015, 05, 5)

            };

            return new List<Peliculas> { pelicula1, pelicula2 };


        }

    }

}