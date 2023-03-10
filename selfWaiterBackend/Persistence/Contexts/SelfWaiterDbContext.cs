using Domain.Entities.Baskets;
using Domain.Entities.Files;
using Domain.Entities.Products;
using Domain.Entities.Products.Translaitons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class SelfWaiterDbContext : DbContext
    {
        public SelfWaiterDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionsTranslation> ProductOptionsTranslations { get; set; }
        public DbSet<SpecialMenu> SpecialMenus { get; set; }
        public DbSet<SpecialMenuTranslation> SpecialMenuTranslations { get; set; }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<ImageFile> ImageFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Basket>()
                .HasOne(b => b.Order)
                .WithOne(o => o.Basket)
                .HasForeignKey<Order>(o => o.Id);


            base.OnModelCreating(modelBuilder);
        }
    }
}
