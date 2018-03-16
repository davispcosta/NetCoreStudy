using Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CursoController : Controller
    {
        private ICursosData _cursosData;

        public CursoController(ICursosData cursosData)
        {
            _cursosData = cursosData;
        }

        public IActionResult Index()
        {
            var model = new CursoIndexViewModel();
            model.Cursos = _cursosData.GetAll();

            return View(model);
        }

        public IActionResult Details(int id) {
            var model = _cursosData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Create()
        {
            var autorCtl = new AutorController();
            var autores = autorCtl.GetAutores();
            return View(autores);
        }
    }
}