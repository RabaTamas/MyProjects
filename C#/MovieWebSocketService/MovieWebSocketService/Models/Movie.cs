using System.ComponentModel.DataAnnotations;

namespace MovieWebSocketService.Models
{
    public class Movie
    {
        [Key]

        public int MovieId { get; set; }

        //[Display(Name = "Title of the Movie")]
        public string Title { get; set; }

        public string Description { get; set; }
        public string MovieImageUrl { get; set; }
        public int Year { get; set; }

        //public ICollection<Actor> Actors { get; set; }
        public List<Actor> Actors { get; set; }

        public Movie()
        {
            Actors = new List<Actor>();
        }

    }
}
