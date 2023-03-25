using Applicaiton.DTOs.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<GetCategoryDTO>> GetAllCategoriesAsync();
        Task<GetCategoryDTO> GetCategoryByIdAsync(string id);
        Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
        Task DeleteCategoryAsync(string id);
        Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);

    }
}
