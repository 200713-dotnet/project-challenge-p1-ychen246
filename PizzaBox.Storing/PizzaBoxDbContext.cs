using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<PizzaModel> Pizzas { get; set; } //create table

    public DbSet<OrderModel> Orders { get; set; }

    public DbSet<UserModel> Users { get; set; }

     public DbSet<StoreModel> Stores { get; set; }

    public PizzaBoxDbContext(DbContextOptions options) : base(options){} //dependency injection

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<PizzaModel>().HasKey(e => e.Id); //primary constraint
      builder.Entity<PizzaModel>().Property(e => e.PizzaPrice).HasColumnType("decimal(18, 2)"); //Decimal Constraint
      builder.Entity<CrustModel>().HasKey(e => e.Id);
      builder.Entity<SizeModel>().HasKey(e => e.Id);
      builder.Entity<ToppingModel>().HasKey(e => e.Id);

      builder.Entity<OrderModel>().Property(e => e.Id);
      builder.Entity<OrderModel>().Property(e => e.OrderPrice).HasColumnType("decimal(18, 2)");

      builder.Entity<UserModel>().Property(e => e.Id);
      builder.Entity<StoreModel>().Property(e => e.Id);
    }
  }
}