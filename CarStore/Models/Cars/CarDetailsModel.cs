namespace CarStore.Models.Cars
{
    using CarStore.Data;
    public class CarDetailsModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        
        public string Model { get; set; }

        public string Type { get; set; }

        public EngineType EngineType { get; set; }

        public double Engine { get; set; }

        public int Power { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }
        
        public decimal Price { get; set; }

        public string AdditionalInformation { get; set; }

        public string ImageUrl { get; set; }

        public string ContactInformation { get; set; }
    }
}