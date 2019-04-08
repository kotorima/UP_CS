using prC_.DAL;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prC_.DAL
{
    public class FilmsRepository : IRepository<Film>
    {
        MySqlConnection connection;

        public FilmsRepository()
        {
            string username = "root";
            string password = "";
            string connectionString = $"Server=localhost;Port=3306;Database=movie;Uid={username};Pwd={password};";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void Create(int id, string name, int year, string country, string prod, Genre genre)
        {

            Console.WriteLine("Привет");
            string commandFilms = $"INSERT INTO film(id, name, year, country, prod, genre) " +
                $"values({id}, '{name}', {year}, '{country}', '{prod}', '{genre}');";
            using (MySqlCommand command = new MySqlCommand(commandFilms, connection))
            {
                Console.WriteLine("Покасики");
                if (command.ExecuteNonQuery() <= 0){
                    Console.WriteLine("Тебе хорошо");
                    throw new Exception("Вставка не удалась!");
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            connection.Close();
        }

        public IEnumerable<Film> Get()
        {
            //using (SqlDataReader reader = command.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("{0} {1} {2}",
            //            reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            //    }
            //}
            throw new NotImplementedException();
        }

        public void Update(int id, string name, int year, string country, string prod, Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}