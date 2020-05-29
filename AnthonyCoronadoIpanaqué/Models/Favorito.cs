using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.Models
{
    public class Favorito
    {
        public int IdFavorito { get; set; }
        
        public bool EsFavorito { get; set; }


        //crear la relacion con pelicula
        
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
