using prC_.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace prC_
{
    public class Studio : Entity
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}