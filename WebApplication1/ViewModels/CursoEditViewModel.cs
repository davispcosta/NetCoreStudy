using Domain.Classes;
using System.Collections.Generic;

namespace WebApplication1.ViewModels
{
    public class CursoEditViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Autor> Autores { get; set; }
    }
}
