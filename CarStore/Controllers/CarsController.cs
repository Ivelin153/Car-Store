namespace CarStore.Controllers
{
    using CarStore.Data;
    using CarStore.Models;
    using CarStore.Models.Cars;
    using Microsoft.AspNet.Identity;
    using System.Linq;
    using System.Web.Mvc;

    public class CarsController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateCarModel carModel)
        {
            if (this.ModelState.IsValid && carModel != null)
            {
                var ownerId = this.User.Identity.GetUserId();

                var car = new Car
                {
                    Make = carModel.Make,
                    Model = carModel.Model,
                    Type = carModel.Type,
                    Year = carModel.Year,
                    EngineType = carModel.EngineType,
                    Engine = carModel.Engine,
                    Power = carModel.Power,
                    Color = carModel.Color,
                    Price = carModel.Price,
                    ImageUrl = carModel.ImageUrl,
                    OwnerId = ownerId
                };

                var db = new CarDbContext();

                db.Cars.Add(car);
                db.SaveChanges();

                return RedirectToAction("Details", new { id = car.Id });
            }

            return View(carModel);
        }

        public ActionResult Details(int id)
        {
            var db = new CarDbContext();

            var car = db.Cars
                .Where(c => c.Id == id)
                .Select(c => new CarDetailsModel
                {
                    Color = c.Color,
                    Engine = c.Engine,
                    EngineType = c.EngineType,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model,
                    Power = c.Power,
                    Price = c.Price,
                    Year = c.Year,
                    ContactInformation = c.Owner.Email
                })
                .FirstOrDefault();

            if (car == null)
            {
                return HttpNotFound();
            }

            return View(car);
        }
        //
        //GET: Cars/All
        public ActionResult All(int page = 1, string user = null)
        {
            var db = new CarDbContext();

            var pageSize = 5;

            var carsQuery = db.Cars.AsQueryable();

            if (user != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Owner.Email == user);
            }


            var cars = carsQuery
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new CarListingModel
                {
                    Id = c.Id,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    Type = c.Type,
                    EngineType = c.EngineType,
                    Engine = c.Engine,
                    Power = c.Power,
                    Price = c.Price
                })
                .ToList();

            ViewBag.CurrentPage = page;

            return View(cars);
        }
    }
}