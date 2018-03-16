using Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Services
{
    public class InMemoryCursosData : ICursosData
    {
        List<Curso> _cursos;

        public InMemoryCursosData()
        {
            _cursos = new List<Curso>
            {
                new Curso
               {
                   Id = 1,
                   Nome = "C# Fundamentos",
                   AutorId = 1
               },
               new Curso
               {
                   Id = 2,
                   Nome = "Linq",
                   AutorId = 1
               }
            };
        }

        public Curso Get(int id)
        {
            return _cursos.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Curso> GetAll()
        {
            return _cursos.OrderBy(c => c.Nome);
        }
    }
}
