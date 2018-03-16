using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int Nota { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
