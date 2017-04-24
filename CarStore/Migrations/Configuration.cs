namespace CarStore.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CarStore.Data.CarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarStore.Data.CarDbContext context)
        {
            if (context.Cars.Any())
            {
                return;
            }

            var user = context.Users.FirstOrDefault();

            if (user == null)
            {
                return;
            }

            context.Cars.Add(new Models.Car
            {
                Make = "Audi",
                Model = "A3",
                Type = "Hatchback",
                Year = 2006,
                EngineType = Data.EngineType.Disel,
                Engine = 2.0,
                Power = 140,
                Color = "Grey metalic",
                Price = 10000,
                ImageUrl = "http://youraccount.ekmpowershop15.com/ekmps/shops/hazzydayzshop/images/audi-a3-8p-rear-facelift-lights-supply-fit-3dr-models-only--[2]-2818-p.jpg",
                OwnerId = user.Id
            });

            context.Cars.Add(new Models.Car
            {
                Make = "Mercedes",
                Model = "C230",
                Type = "Sedan",
                Year = 2015,
                EngineType = Data.EngineType.Petrol,
                Engine = 2.3,
                Power = 190,
                Color = "White",
                Price = 110000,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/2015_Mercedes-Benz_C_200_%28W_205%29_sedan_%282015-07-03%29_01.jpg/1200px-2015_Mercedes-Benz_C_200_%28W_205%29_sedan_%282015-07-03%29_01.jpg",
                OwnerId = user.Id
            });

            context.Cars.Add(new Models.Car
            {
                Make = "BMW",
                Model = "330",
                Type = "Coupe",
                Year = 2008,
                EngineType = Data.EngineType.Disel,
                Engine = 3.0,
                Power = 140,
                Color = "Black",
                Price = 30000,
                ImageUrl = "http://m.netinfo.bg/media/images/31461/31461004/r-800-600-bmw-330.jpg",
                OwnerId = user.Id
            });

            context.Cars.Add(new Models.Car
            {
                Make = "Maybach",
                Model = "S600",
                Type = "Sedan",
                Year = 2015,
                EngineType = Data.EngineType.Petrol,
                Engine = 2.3,
                Power = 385,
                Color = "Dark Blue",
                Price = 210000,
                ImageUrl = "https://assets.mbusa.com/vcm/MB/DigitalAssets/Vehicles/Models/2016/S600X/Features/2016-S-CLASS-MAYBACH-005-MCFO.jpg",
                OwnerId = user.Id
            });

            context.Cars.Add(new Models.Car
            {
                Make = "Audi",
                Model = "A8",
                Type = "Sedan",
                Year = 2016,
                EngineType = Data.EngineType.Petrol,
                Engine = 4.0,
                Power = 400,
                Color = "Black",
                Price = 150000,
                ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQVN9VA4Gjku5EWdsrNG1i8Nn0naftaM_0xOKv6E640Nb8fGSvj8QGrud0",
                OwnerId = user.Id
            });

            context.Cars.Add(new Models.Car
            {
                Make = "Mercedes",
                Model = "S63",
                Type = "Coupe",
                Year = 2017,
                EngineType = Data.EngineType.Petrol,
                Engine = 6.0,
                Power = 630,
                Color = "Silver",
                Price = 110000,
                ImageUrl = "http://blogmedia.dealerfire.com/wp-content/uploads/sites/316/2015/08/2017-Mercedes-AMG-S63-Convertible-release-date.jpg",
                OwnerId = user.Id
            });


        }
    }
}
