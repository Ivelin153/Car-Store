namespace CarStore.Models
{
    using CarStore.Data;
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public string Type { get; set; }

        public EngineType EngineType { get; set; }

        public double Engine { get; set; }

        public int Power { get; set; }

        [Range(1950, 2017)]
        public int Year { get; set; }

        public string Color { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        public string AdditionalInformation { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string OwnerId { get; set; }
        public virtual User Owner { get; set; }
    }
}