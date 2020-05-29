using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.Models
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        
        public string Nombre { get; set; }
        
        public string Imagen { get; set; }
        
        public DateTime Año { get; set; }


        //crear la relacion con director
        [Required]
        public int DirectorId { get; set; }
        public Director Director { get; set; }


        //relacion con favorito
        public List<Favorito> Favoritos { get; set; }
    }
}
