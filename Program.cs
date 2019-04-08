
using prC_.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prC_
{
    class Program
    {
        private static Film GetGreenBook()
        {
            Film GreenBook = new Film();
            GreenBook.Awards = new Awards
            {
                Oscar = true,
                GoldenGlob = true,
                Bafta = false
            };
            GreenBook.Name = "Green Book";
            GreenBook.Year = 2018;
            GreenBook.Prod = "Piter  Farrelle";
            GreenBook.Country = "USA";
            GreenBook.Studio = new Studio()
            {
                Name = "Dream Works SKG",
                Year = 1994
            };
            GreenBook.Genre = Genre.Camedy;

            return GreenBook;
        }

         private static Film GetRoma()
        {
            Film Roma = new Film();
            Roma.Awards = new Awards
            {
                Oscar = true,
                GoldenGlob = true,
                Bafta = true
            };
            Roma.Name = "Roma";
            Roma.Year = 2018;
            Roma.Prod = "Alfonso Kuyaron";
            Roma.Country = "Mexico";
            Roma.Studio = new Studio()
            {
                Name = "Esperanto Filmoj",
                Year = 2004
            };
            Roma.Genre = Genre.Drama;

            return Roma;
        }

         private static Film GetLaLaLand()
        {
            Film LaLaLand = new Film();
            LaLaLand.Awards = new Awards
            {
                Oscar = true,
                GoldenGlob = true,
                Bafta = true
            };
            LaLaLand.Name = "La-La Land";
            LaLaLand.Year = 2016;
            LaLaLand.Prod = "Damien Shasell";
            LaLaLand.Country = "USA ";
            LaLaLand.Studio = new Studio()
            {
                Name = "Black Label Media",
                Year = 2013
            };
            LaLaLand.Genre = Genre.Drama;

            return LaLaLand;
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Film greenBook = GetGreenBook();
            Film roma = GetRoma();
            Film laLaLand = GetLaLaLand();

            List<Film> films = new List<Film>{
                greenBook,
                roma,
                laLaLand
            };

            FilmsRepository filmsRepo = new FilmsRepository();
            int i = 10;
            foreach (var film in films)
            {
                filmsRepo.Create(i,
                    film.Name,
                    film.Year,
                    film.Country,
                    film.Prod,
                    film.Genre);
                i++; //лучше добавить автоинкремент в бд
            }
            Console.ReadKey();

        //     WriteFilmsInfo(films);
        //     Console.WriteLine("Выберите номер сортировки:\n1)По году;\n" +
        //         "2)По названию фильма\r\n");
        //     int s = Convert.ToInt32(Console.ReadLine());
        //     bool isOkInput = true;
        //     if (s == 1)
        //     {
        //         SortByYear(films, true);
        //         Console.WriteLine("После сортировки году:");
        //     }
        //     else if (s == 2)
        //     {
        //         films.Sort();
        //         Console.WriteLine("После сортировки по названию фильма:");
        //     }
        //     else
        //     {
        //         isOkInput = false;
        //         Console.WriteLine("Неверный метод сортировки");
        //     }
        //     if (isOkInput)
        //     {
        //         WriteFilmsInfo(films);
        //     }   

        //     Console.ReadKey();
        // }

        // private static void SortByYear(List<Film> films, bool isAscending)
        // {
        //     for (int i = 0; i < films.Count; i++)
        //     {
        //         for (int j = 0; j < films.Count - i - 1; j++)
        //         {
        //             if (isAscending)
        //             {
        //                 if (films[j].Year > films[j + 1].Year)
        //                 {
        //                     Film temp = films[j];
        //                     films[j] = films[j + 1];
        //                     films[j + 1] = temp;
        //                 }
        //             }
        //             else
        //             {
        //                 if (films[j].Year < films[j + 1].Year)
        //                 {
        //                     Film temp = films[j];
        //                     films[j] = films[j + 1];
        //                     films[j + 1] = temp;
        //                 }
        //             }
        //         }
        //     }
        // }

        // private static void WriteFilmsInfo(List<Film> films)
        // {
        //     Console.WriteLine("Список фильмов:\r\n");
        //     int n = 1;
        //     foreach(var film in films)
        //     {
        //         Console.WriteLine($"Фильм: {n}:\r\n");
        //         n++;
        //         string filmInfo = $"Название: {film.Name}\r\n" +
        //             $"Год выпуска: {film.Year}\r\n" +
        //             $"Страна: {film.Country}\r\n" +
        //             $"Жанр: {film.Genre}\r\n" +
        //             $"Режисер: {film.Prod}\r\n" +
        //             $"Награды:\r\n" +
        //             $"Оскар: {(film.Awards.Oscar == true ? "есть" : "нет")}\r\n" +
        //             $"Золотой Глобус: {(film.Awards.GoldenGlob == true ? "есть" : "нет")}\r\n" +
        //             $"BAFTA: {(film.Awards.Bafta == true ? "есть" : "нет")}\r\n" +
        //             $"Студия:\r\n" +
        //             $"Название: {film.Studio.Name}\r\n" +
        //             $"Количество ладов: {film.Studio.Year}\r\n";

        //         Console.WriteLine(filmInfo);
        //     }
        }
    }
}
