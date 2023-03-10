using Core.Persistence.Entities;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Files
{
    public class ImageFile:ModelEntity
    {
        public string FileName { get; set; }   
        public string Path { get; set; }
        public string Storage { get; set; }

        [NotMapped]
        public override DateTime UpdatedDate { get => base.UpdatedDate; set => base.UpdatedDate = value; }

        public ICollection<Product> Products { get; set; }

    }
}
