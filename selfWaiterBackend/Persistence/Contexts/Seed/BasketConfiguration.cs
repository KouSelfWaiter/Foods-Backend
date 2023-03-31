using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Baskets;
using Domain.Entities.Products;
using Persistence.Extensions;

namespace Persistence.Contexts.Seed
{
    public class BaskettConfiguration : IEntityTypeConfiguration<Basket>

    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {

          builder.HasData(new Basket()
          {

                Id = Guid.Parse("000ac947-a4f7-4785-9a48-b46e2a600001"),
                TableNo = "1",

                IsDeleted = false,
                IsActive = false,
                CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
                UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


          },
          new Basket()
          {

              Id = Guid.Parse("000ac947-a4f7-4785-9a48-b46e2a600002"),
              TableNo = "1",

              IsDeleted = false,
              IsActive = false,
              CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
              UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


          },
          new Basket()
          {

              Id = Guid.Parse("000ac947-a4f7-4785-9a48-b46e2a600003"),
              TableNo = "1",

              IsDeleted = false,
              IsActive = true,
              CreatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),
              UpdatedDate = new DateTime(2023, 3, 31).SetKind(DateTimeKind.Utc),


          });
        }
    }
}
