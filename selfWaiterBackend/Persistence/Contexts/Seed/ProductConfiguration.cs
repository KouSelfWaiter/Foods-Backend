using Domain.Entities.Products.Translaitons;
using Domain.Entities.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Applicaiton.Enums;
using System.Xml.Linq;
using Persistence.Extensions;

namespace Persistence.Contexts.Seed
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>

    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600001"),
                Price = 48,
                CategoryId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                IsDeleted = false,
                IsActive = true,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            },
            new Product()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600002"),
                Price = 50,
                CategoryId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),
                IsDeleted = false,
                IsActive = true,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            },
            new Product()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600003"),
                Price = 50,
                CategoryId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                IsDeleted = false,
                IsActive = true,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            },
            new Product()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600004"),
                Price = 24,
                CategoryId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),


                IsDeleted = false,
                IsActive = true,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            },
            new Product()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600005"),
                Price = 24,
                CategoryId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),
                IsDeleted = false,
                IsActive = true,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),



            }, new Product()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600006"),
                Price = 24,
                CategoryId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                IsDeleted = false,
                IsActive = true,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),



            });
        }
    }
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>

    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {

            builder.HasData(new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600001"),
                Name = "Portakal Suyu",
                Description = "",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600002"),

                TranslationCode = TranslationCode.tr_TR,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            },
            new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600101"),
                Name = "Orange Juice",
                Description = "",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600002"),

                TranslationCode = TranslationCode.en_EN,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            }, new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600002"),
                Name = "Lahmacun",
                Description = "Nefis lahmacun",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600001"),

                TranslationCode = TranslationCode.tr_TR,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            }, new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600003"),
                Name = "MilkShake",
                Description = "Ağzınızı Serinletecek buz gibi milkshake",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600004"),

                TranslationCode = TranslationCode.tr_TR,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            }, new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600004"),
                Name = "Türk Kahvesi",
                Description = "Taze çekilmiş türk kahvesi ile 40 yıl hatır",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600005"),

                TranslationCode = TranslationCode.tr_TR,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            }, new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600104"),
                Name = "Turkish coffee",
                Description = "40 years of memory with freshly ground Turkish coffee",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600005"),

                TranslationCode = TranslationCode.en_EN,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            },new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600005"),
                Name = "Kıymalı Pide",
                Description = "Yöresel Kıymalı Pide",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600003"),

                TranslationCode = TranslationCode.tr_TR,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            }, new ProductTranslation()
            {

                Id = Guid.Parse("000ec947-c4f7-4785-9b48-d46e2a600006"),
                Name = "Çorba",
                Description = "",
                RelationId = Guid.Parse("000ec947-c4f7-4785-9a48-d46e2a600006"),

                TranslationCode =TranslationCode.tr_TR,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


            }); 

        }
    }
}
