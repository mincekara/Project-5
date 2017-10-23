using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Specification> specifications { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=1510;Host=localhost;Port=5432;Database=RoboMarktDB;Pooling=true;");
        }
    }

    public class Product
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public List<Specification> specifications { get; set; }
    }

    public class Specification
    {
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public int productid { get; set; }
        public Product product { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}