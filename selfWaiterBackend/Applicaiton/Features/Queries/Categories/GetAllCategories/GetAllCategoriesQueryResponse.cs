﻿using Applicaiton.DTOs.CategoryDTO;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Features.Queries.Categories.GetAllCategories
{
    public class GetAllCategoriesQueryResponse
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public List<GetCategoryTranslationDTO> Translations { get; set; }
    }
}
