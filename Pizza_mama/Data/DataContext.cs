using Microsoft.EntityFrameworkCore;
using Pizza_mama.Models;

namespace Pizza_mama.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //Collecction de Pizza qui permet de faire le CRUD
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
