using Core.Applicaiton.Enums;
using Core.Persistence.Entities;
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
            modelBuilder.Entity<Category>().
              HasData(new Category()
              {
                  Id = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                  IsDeleted = false,
                  IsActive = true,
                  CreatedDate = DateTime.UtcNow,
                  UpdatedDate = DateTime.UtcNow,


              }, new Category()
              {
                  Id = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),
                  IsDeleted = false,
                  IsActive = true,
                  CreatedDate = DateTime.UtcNow,
                  UpdatedDate = DateTime.UtcNow,


              }, new Category()
              {
                  Id = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600003"),
                  IsDeleted = false,
                  IsActive = true,
                  CreatedDate = DateTime.UtcNow,
                  UpdatedDate = DateTime.UtcNow,


              });

            modelBuilder.Entity<CategoryTranslation>()
                .HasData(new CategoryTranslation()
                {

                    Id = Guid.Parse("000ec947-a4f7-4785-9a48-d46e2a600001"),
                    Name = "Yiyecek",
                    RelationId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                    TranslationCode = TranslationCode.tr_TR,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,


                }, new CategoryTranslation()
                {
                    Id = Guid.Parse("000ec947-a4f7-4785-9a48-d46e2a600002"),
                    Name = "İçecek",
                    RelationId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),
                    TranslationCode = TranslationCode.tr_TR,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,

                }, new CategoryTranslation()
                {
                    Id = Guid.Parse("000ec947-a4f7-4785-9a48-d46e2a600003"),
                    Name = "Tatlı",
                    RelationId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600003"),
                    TranslationCode = TranslationCode.tr_TR,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                });

            base.OnModelCreating(modelBuilder);
        }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           
            var datas = ChangeTracker.Entries<Entity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
