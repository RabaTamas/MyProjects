using Otthonbazar.Data;
using System.ComponentModel.DataAnnotations;

namespace Otthonbazar.Models
{
    public class SearchModel
    {
        public int? CityId { get; set; }

        [Display(Name = "Város")]
        public string CityName { get; set; }

       
        public decimal? PriceMax { get; set; }

        [Display(Name = "Ár")]
        public decimal? PriceMin { get; set; }


        
        public int? RoomMax { get; set; }

        [Display(Name = "Szobák")]
        public int? RoomMin { get; set; }

       
        public int? SizeMax { get; set; }

        [Display(Name = "Alapterület")]
        public int? SizeMin { get; set; }

    }
}
