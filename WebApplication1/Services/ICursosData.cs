using Domain.Classes;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    public interface ICursosData
    {
        IEnumerable<Curso> GetAll();
        Curso Get(int id);
    }
}
