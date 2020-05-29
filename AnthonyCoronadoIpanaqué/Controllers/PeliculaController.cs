using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnthonyCoronadoIpanaqué.DB;
using AnthonyCoronadoIpanaqué.Models;
using AnthonyCoronadoIpanaqué.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AnthonyCoronadoIpanaqué.Controllers
{
    public class PeliculaController : Controller
    {
        public IActionResult Index()
        {
            
            var contex = new AppPruebaContex();
            var model = contex.Peliculas
                .Include(o => o.Director);
            return View(model.ToList());
        }



        [HttpGet]
        public IActionResult Crear()
        {
            var contex = new AppPruebaContex();
            ViewBag.Director = contex.Directores.ToList();
            return View(new Pelicula());
        }

        [HttpPost]
        public IActionResult Crear(Pelicula pelicula)
        {

           
            var contex = new AppPruebaContex();
            validar(pelicula);
            ViewBag.Director = contex.Directores.ToList();
            if (ModelState.IsValid == true)
            {
                contex.Peliculas.Add(pelicula);
                contex.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pelicula);

        }



        //validaciones
        public void validar(Pelicula pelicula)
        {


            if (pelicula.Nombre == null || pelicula.Nombre == "")
                ModelState.AddModelError("Nombre", "El campo nombre es obligatorio");

            if (pelicula.Año == null )
                ModelState.AddModelError("Año", "El campo año es obligatorio");

            if (pelicula.Imagen == null || pelicula.Imagen == "")
                ModelState.AddModelError("Imagen", "El campo imagen es obligatorio");


        }


        public IActionResult Mostar(string query)
        {

            var contex = new AppPruebaContex();
            var model = contex.Peliculas
                .Include(o => o.Director);


            if (!String.IsNullOrEmpty(query))
                return View(model.Where(o => o.Nombre.Contains(query)));

            //if (!String.IsNullOrEmpty(query))
            //    model = model.Where(o => o.Nombre.Contains(query));


            ViewBag.Query = query;
            return View(model.ToList());

        }


    }
}

