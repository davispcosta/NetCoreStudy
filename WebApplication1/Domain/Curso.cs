using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Curso
    {
        public Curso()
        {
            Avaliacoes = new List<Avaliacao>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
