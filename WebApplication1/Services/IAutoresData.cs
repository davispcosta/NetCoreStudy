using Domain.Classes;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    interface IAutoresData
    {
        IEnumerable<Autor> GetAll();
        Autor Get(int id);
    }
}
