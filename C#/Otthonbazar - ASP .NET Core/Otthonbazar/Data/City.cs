using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Data
{
    public class City
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Az irányítószám megadása kötelező"), StringLength(4, MinimumLength = 4)]
        [Display(Name = "Irányítószám")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "A város megadása kötelező")]
        [Display(Name = "Város")]
        public string Name { get; set; }
        public ICollection<Advertisement>? Advertisements { get; set; }
    }
}
