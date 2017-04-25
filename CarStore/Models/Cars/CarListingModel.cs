using CarStore.Data;

namespace CarStore.Models.Cars
{
    public class CarListingModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int Year { get; set; }

        public string Type { get; set; }

        public EngineType EngineType { get; set; }

        public double Engine { get; set; }

        public int Power { get; set; }

        public string ImageUrl { get; set; }
    }
}