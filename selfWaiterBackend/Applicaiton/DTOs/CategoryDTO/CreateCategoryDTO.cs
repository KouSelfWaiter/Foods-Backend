using Core.Applicaiton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.DTOs.CategoryDTO
{
    public class CreateCategoryDTO
    {
        public TranslationCode TranslationCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
