using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public interface IManager326239886Context
    {
        DbSet<Category> Categories { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<User> Users { get; set; }
    }
}