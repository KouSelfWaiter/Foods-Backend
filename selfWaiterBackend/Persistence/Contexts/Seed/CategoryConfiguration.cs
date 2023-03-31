using Core.Applicaiton.Enums;
using Domain.Entities.Products;
using Domain.Entities.Products.Translaitons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts.Seed
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>

    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            
              builder.HasData(new Category()
              {
                  Id = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                  IsDeleted = false,
                  IsActive = true,
                  CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                  UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


              }, new Category()
              {
                  Id = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),
                  IsDeleted = false,
                  IsActive = true,
                  CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                  UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


              }, new Category()
              {
                  Id = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600003"),
                  IsDeleted = false,
                  IsActive = true,
                  CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                  UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


              });

        }
    }
    public class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>

    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {

             builder.HasData(new CategoryTranslation()
             {

                 Id = Guid.Parse("000ec947-a4f7-4785-9a48-d46e2a600001"),
                 Name = "Yiyecek",
                 RelationId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600001"),
                 TranslationCode = TranslationCode.tr_TR,
                 CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                 UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


             }, new CategoryTranslation()
             {
                 Id = Guid.Parse("000ec947-a4f7-4785-9a48-d46e2a600002"),
                 Name = "İçecek",
                 RelationId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600002"),
                 TranslationCode = TranslationCode.tr_TR,
                 CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                 UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),

             }, new CategoryTranslation()
             {
                 Id = Guid.Parse("000ec947-a4f7-4785-9a48-d46e2a600003"),
                 Name = "Tatlı",
                 RelationId = Guid.Parse("000ec947-d4f7-4785-9a48-d46e2a600003"),
                 TranslationCode = TranslationCode.tr_TR,
                 CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                 UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
             });
        }
    }
}
