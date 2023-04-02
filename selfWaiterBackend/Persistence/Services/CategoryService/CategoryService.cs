using Applicaiton.DTOs.CategoryDTO;
using Applicaiton.Exceptions;
using Applicaiton.Services.CategoryService;
using Applicaiton.Services.Repositories.CategoryRepository;
using Applicaiton.Services.Repositories.Translations.CategoryTranslationRepository;
using Core.Applicaiton.Enums;
using Domain.Entities.Products;
using Domain.Entities.Products.Translaitons;
using Microsoft.EntityFrameworkCore;
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

        public async Task CreateCategoryTranslationAsync(CreateCategoryTranslationDTO categoryTranslationDTO)
        {
            Category? category = await _readRepository.Table.Include(c => c.Translations)
                                                            .FirstOrDefaultAsync(c => c.Id == Guid.Parse(categoryTranslationDTO.CategoryId));
            if (category == null)
                throw new CategoryNotFoundException();

            category.Translations.ForEach(ct =>
            {
                if (ct.TranslationCode == categoryTranslationDTO.TranslationCode)
                    throw new TranslationAlreadyExist();
            });

            category.Translations.Add(new()
            {
                Name = categoryTranslationDTO.Name,
                TranslationCode = categoryTranslationDTO.TranslationCode
            });

            _ = await _writeRepository.SaveAsync();
        }

        public async Task DeleteCategoryAsync(string id)
        {
            Category deletedCategory = await _readRepository.GetByIdAsync(id, false);
            _ = _writeRepository.Remove(deletedCategory);
            _ = await _writeRepository.SaveAsync();
        }

        public async Task<List<GetCategoryDTO>> GetAllCategoriesAsync()
        {
            List<Category> categories = await _readRepository.Table
                                                             .Include(c => c.Translations).ToListAsync();
                                                               
            List<GetCategoryDTO> result = new List<GetCategoryDTO>();

            categories.ForEach(c =>
            {
                List<GetCategoryTranslationDTO> getCategoryTranslationDTOs= new List<GetCategoryTranslationDTO>();
                //include all translations
                c.Translations.ForEach(ct =>
                {
                    getCategoryTranslationDTOs.Add(new() { Name = ct.Name, TranslationCode = ct.TranslationCode });
                });
  
                result.Add(new GetCategoryDTO()
                {
                    Id = c.Id.ToString(),
                    IsActive = c.IsActive,
                    Translations = getCategoryTranslationDTOs
                });
            });

            return result;
        }

        public async Task<GetCategoryDTO> GetCategoryByIdAsync(string id)
        {
            Category? category = await _readRepository.Table.Include(c => c.Translations)
                                                           .FirstOrDefaultAsync(c => c.Id == Guid.Parse(id));

            if (category == null)
                throw new CategoryNotFoundException();


            List<GetCategoryTranslationDTO> getCategoryTranslationDTOs = new List<GetCategoryTranslationDTO>();
            category.Translations.ForEach(ct =>
            {
                getCategoryTranslationDTOs.Add(new GetCategoryTranslationDTO() { Name = ct.Name, TranslationCode= ct.TranslationCode });
            });

            return new()
            {
                Id = category.Id.ToString(),
                IsActive= category.IsActive,
                Translations = getCategoryTranslationDTOs
            };
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO)
        {
            Category? category = await _readRepository.Table.Include(c => c.Translations)
                                                           .FirstOrDefaultAsync(c => c.Id == Guid.Parse(updateCategoryDTO.Id));
            if (category == null)
                throw new CategoryNotFoundException();

            category.IsDeleted = updateCategoryDTO.IsDeleted;
            category.IsActive = updateCategoryDTO.IsActive;

            category.Translations.ForEach(t =>
            {
                if (t.TranslationCode == updateCategoryDTO.TranslationCode)
                {
                    t.Name = updateCategoryDTO.Name;
                }
            });

            _ = await _readRepository.SaveAsync();
         
        }

        public async Task UpdateCategoryTranslationAsync(CreateCategoryTranslationDTO categoryTranslationDTO)
        {
            Category? category = await _readRepository.Table.Include(c => c.Translations)
                                                            .FirstOrDefaultAsync(c => c.Id == Guid.Parse(categoryTranslationDTO.CategoryId));
            if (category == null)
                throw new CategoryNotFoundException();

            category.Translations.ForEach(ct =>
            {
                if(ct.TranslationCode == categoryTranslationDTO.TranslationCode)
                {
                    ct.Name = categoryTranslationDTO.Name;
                }
            });

            _ = await _readRepository.SaveAsync();
        }
    }
}
