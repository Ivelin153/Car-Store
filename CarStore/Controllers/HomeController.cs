namespace CarStore.Controllers
{
    using System.Web.Mvc;
    using CarStore.Data;
    using System.Linq;
    using Models.Cars;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new CarDbContext();

            var cars = db.Cars
                .OrderByDescending(c => c.Id)
                .Take(3)
                .Select(c => new CarListingModel
                {
                    Id = c.Id,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model
                })
                .ToList();

            return View(cars);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}