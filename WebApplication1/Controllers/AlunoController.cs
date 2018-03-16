using Microsoft.AspNetCore.Mvc;
using Domain.Classes;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno
                {
                    Id = 1,
                    Nome = "Alexandre",
                    Idade = 23,
                    Email = "alexandre.ribeiro@iviatecnologia.com"
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Guilherme",
                    Idade = 20,
                    Email = "guilherme.macedo@iviatecnologia.com"
                },
                new Aluno
                {
                    Id = 3,
                    Nome = "Alvaro",
                    Idade = 23,
                    Email = "alvaro.oliveira@iviatecnologia.com"
                },
                new Aluno
                {
                    Id = 4,
                    Nome = "Davi",
                    Idade = 20,
                    Email = "davi.sampaio@iviatecnologia.com"
                },
                new Aluno
                {
                    Id = 4,
                    Nome = "Daniel",
                    Idade = 22,
                    Email = "daniel.evangelista@iviatecnologia.com"
                },
            };
            return View(alunos);
        }
    }
}
