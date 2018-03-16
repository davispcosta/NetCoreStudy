using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Classes;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AutorController : Controller
    {
        private IAutoresData _autoresData;

        public IEnumerable<Autor> GetAutores()
        {
            var model = new AutorIndexViewModel();
            var autores = _autoresData.GetAll();
            return autores;
        }

        public IActionResult Index()
        {
            var model = new AutorIndexViewModel();
            var autores = _autoresData.GetAll();
            return (IActionResult) autores;
        }
    }
}