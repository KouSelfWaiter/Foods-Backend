using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Services.CategoryService;
using Applicaiton.Services.Repositories.CategoryRepository;
using Applicaiton.Services.Repositories.Translations.CategoryTranslationRepository;
using Core.Applicaiton.Enums;
using Domain.Entities.Products;
using Domain.Entities.Products.Translaitons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryReadRepository _readRepository;
        private readonly ICategoryWriteRepository _writeRepository;

        public CategoryService(ICategoryReadRepository readRepository, ICategoryWriteRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
        { 
            Category category = new Category()
            {
                IsActive = createCategoryDTO.IsActive,
                
            };
            category.Translations.Add(
                    new CategoryTranslation()
                    {
                        Name = createCategoryDTO.Name,
                        TranslationCode = createCategoryDTO.TranslationCode
                    }
                );

            _ = await _writeRepository.AddAsync( category );
            _ = await _writeRepository.SaveAsync();
           
        }

        public async Task DeleteCategoryAsync(string id)
        {
            Category deletedCategory = await _readRepository.GetByIdAsync(id, false);
            _ = _writeRepository.Remove(deletedCategory);
            _ = await _writeRepository.SaveAsync();
        }

        public Task<List<GetCategoryDTO>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryDTO> GetCategoryByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
