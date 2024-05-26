using System.ComponentModel.DataAnnotations;

namespace MovieWebSocketService.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }


        //[Required(ErrorMessage = "Name must be given")]
        //[Display(Name = "Name")]
        public string? Name { get; set; }

        //[Required(ErrorMessage = "CV must be given")]
        //[Display(Name = "CV")]
        public string? CV { get; set; }

        //[Required(ErrorMessage = "PictureUrl must be given")]
        //[Display(Name = "Picture(Url)")]
        public string? PictureUrl { get; set; }

        //public ICollection<Movie> Movies { get; set; }
        public List<Movie>? Movies { get; set; }

        public Actor()
        {
            Movies = new List<Movie>();
        }
    }
}
