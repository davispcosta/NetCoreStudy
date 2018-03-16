using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Aluno
    {
        public Aluno()
        {
            Avaliacoes = new List<Avaliacao>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
