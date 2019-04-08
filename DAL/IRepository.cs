using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prC_.DAL
{
    interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> Get(); // получение всех объектов

        void Create(int id, string name, int year, string country, string prod, Genre genre);
        void Delete(int id);
        void Update(int id, string name, int year, string country, string prod, Genre genre);
    }
}