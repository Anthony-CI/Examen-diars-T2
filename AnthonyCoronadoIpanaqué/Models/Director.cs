using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.Models
{
    public class Director
    {
        public int IdDirector { get; set; }
        
        public string Nombre { get; set; }

        //crear la relacion con director
        public List<Pelicula> Peliculas { get; set; }
    }
}
