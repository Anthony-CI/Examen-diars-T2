using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnthonyCoronadoIpanaqué.DB;
using AnthonyCoronadoIpanaqué.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnthonyCoronadoIpanaqué.Controllers
{
    public class FavoritoController : Controller
    {
        public IActionResult Index()
        {
            
            var contex = new AppPruebaContex();
            var model = contex.Favoritos
                .Include(o => o.Pelicula);
                
            return View(model.ToList());
        }
        [HttpGet]
        public IActionResult Crear()
        {
            var contex = new AppPruebaContex();
            ViewBag.Pelicula = contex.Peliculas.ToList();
            return View(new Favorito());
        }

        [HttpPost]
        public IActionResult Crear(Favorito favorito)
        {

           
            var contex = new AppPruebaContex();
            if (!ModelState.IsValid)
            {
                ViewBag.Pelicula = contex.Peliculas.ToList();
                return View(favorito);
            }

            
            contex.Favoritos.Add(favorito);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}