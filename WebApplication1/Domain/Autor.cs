using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Autor
    {
        public Autor()
        {
            Cursos = new List<Curso>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
