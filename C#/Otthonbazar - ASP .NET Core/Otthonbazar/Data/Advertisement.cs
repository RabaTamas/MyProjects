using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Data
{
    public class Advertisement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A cím megadása kötelező")]
        [Display(Name = "Cím")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Az építés évének megadása kötelező")]
        [Display(Name = "Építés éve")]
        public int BuildDate { get; set; }

        [Display(Name = "Leírás")]
        public string Description { get; set; }


        [Required(ErrorMessage = "A fél szobák számának megadása kötelező")]
        [Display(Name = "Fél szobák száma")]
        public int HalfRoom { get; set; }

        [Display(Name = "Kép")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Az ár megadása kötelező")]
        [Display(Name = "Ár")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "A szobák számának megadása kötelező")]
        [Display(Name = "Szobák száma")]
        public int Room { get; set; }


        [Required(ErrorMessage = "A méret megadása kötelező")]
        [Display(Name = "Méret")]
        public int Size { get; set; }


        [Required(ErrorMessage = "A típus megadása kötelező")]
        [Display(Name = "Típus")]
        public AdvertisementType AdvertisementType { get; set; }



        [Required]
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
