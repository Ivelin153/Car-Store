namespace CarStore.Data
{
    using CarStore.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class CarDbContext : IdentityDbContext<User>
    {
        public CarDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Car> Cars { get; set; }

        public static CarDbContext Create()
        {
            return new CarDbContext();
        }
    }
}