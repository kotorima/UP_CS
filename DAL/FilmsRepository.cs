using System.Collections.Generic;
using System.Linq;

namespace prC_.DAL
{
    public class FilmsRepository : IRepository<Film>
    {
        FilmContext db;
        public FilmsRepository()
        {
            db = new FilmContext();
        }

        public void Create(string name, int year, string country, string prod, Genre genre)
        {
            Film creatingFilm = new Film
            {
                Name = name,
                Year = year,
                Country = country,
                Prod = prod,
                Genre = genre
            };
            db.Films.Add(creatingFilm);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Film deletingFilm = db.Films.Where(f => f.Id == id).FirstOrDefault();
            db.Films.Remove(deletingFilm);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Film> Get()
        {
            return db.Films;
        }

        public void Update(int id, string name, int year, string country, string prod, Genre genre)
        {
            Film updatingFilm = db.Films.Where(f => f.Id == id).FirstOrDefault();
            updatingFilm.Name = name;
            updatingFilm.Year = year;
            updatingFilm.Country = country;
            updatingFilm.Prod = prod;
            updatingFilm.Genre = genre;
            db.SaveChanges();
        }
    }
}