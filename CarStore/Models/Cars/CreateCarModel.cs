namespace CarStore.Models.Cars
{
    using CarStore.Data;
    using CarStore.Helpers;
    using System.ComponentModel.DataAnnotations;

    public class CreateCarModel
    {
        [Required]
        [StringLength(20)]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public string Type { get; set; }

        [Display(Name = "Engine Type")]
        [ScaffoldColumn(false)]
        public EngineType EngineType { get; set; }

        public double Engine { get; set; }

        public int Power { get; set; }

        [Range(1950, 2017)]
        public int Year { get; set; }

        public string Color { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Additional Information")]
        [ScaffoldColumn(false)]
        public string AdditionalInformation { get; set; }

        [Url]
        [ImageURL]
        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}