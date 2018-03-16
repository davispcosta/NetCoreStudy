using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Classes;

namespace WebApplication1.Services
{
    public class InMemoryAutoresData : IAutoresData
    {
        List<Autor> _autores;

        public InMemoryAutoresData()
        {
            _autores = new List<Autor>
            {
                new Autor
               {
                   Id = 1,
                   Nome = "Scott Allen",
               },
               new Autor
               {
                   Id = 2,
                   Nome = "Julie Lerman",
               }
            };
        }

        public Autor Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autor> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
