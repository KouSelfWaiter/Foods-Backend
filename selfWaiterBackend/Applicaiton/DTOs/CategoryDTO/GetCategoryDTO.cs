using Core.Applicaiton.Enums;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.CategoryDTO
{
    public class GetCategoryDTO
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public List<GetCategoryTranslationDTO> Translations { get; set; }
      
    }

    public class GetCategoryTranslationDTO
    {
        public TranslationCode TranslationCode { get; set; }
        public string Name { get; set; }
    }
}
