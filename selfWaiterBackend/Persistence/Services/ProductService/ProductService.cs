using Applicaiton.DTOs.ProductDTO;
using Applicaiton.Exceptions;
using Applicaiton.Services.CategoryService;
using Applicaiton.Services.ProductService;
using Applicaiton.Services.Repositories.CategoryRepository;
using Applicaiton.Services.Repositories.ProductRepository;
using Domain.Entities.Products;
using Domain.Entities.Products.Translaitons;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductReadRepository _readRepository;
        private readonly IProductWriteRepository _writeRepository;

        private readonly ICategoryReadRepository _categoryReadRepository;


        public ProductService(IProductWriteRepository writeRepository, IProductReadRepository readRepository, ICategoryReadRepository categoryReadRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task CreateProductAsync(CreateProductDTO createProductDTO)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(createProductDTO.CategoryId);

            if(category == null)
            {
                throw new CategoryNotFoundException();
            }

            Product addedProduct = new Product()
            {
                IsActive = createProductDTO.IsActive,
                Price= createProductDTO.Price,
                Translations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Description = createProductDTO.Description,
                        Name = createProductDTO.Name,
                        TranslationCode = createProductDTO.TranslationCode,
                    }
                },
                Category= category,   
                
            };


            _ = await _writeRepository.AddAsync(addedProduct);
            _ = await _writeRepository.SaveAsync();
            
        }

        public async Task CreateProductTranslationAsync(CreateProductTranslationDTO productTranslationDTO)
        {
            Product? product = await _readRepository.Table.Include(p => p.Translations)
                                                         .FirstOrDefaultAsync(p => p.Id == Guid.Parse(productTranslationDTO.ProductId));
            if (product == null)
                throw new ProductNotFoundException();

            product.Translations.ForEach(pt =>
            {
                if (pt.TranslationCode == productTranslationDTO.TranslationCode)
                    throw new TranslationAlreadyExist();
            });

            product.Translations.Add(new ProductTranslation()
            {
                TranslationCode= productTranslationDTO.TranslationCode,
                Name = productTranslationDTO.Name,
                Description = productTranslationDTO.Description
            });

            _ = await _readRepository.SaveAsync();
            
        }

        public async Task DeleteProductAsync(string id)
        {
            Product product = await _readRepository.GetByIdAsync(id);
            if(product == null)  throw new ProductNotFoundException();

            _ = _writeRepository.Remove(product);
            _ = await _writeRepository.SaveAsync();
        }

        public async Task<List<GetProductDTO>> GetAllProductsAsync(int size, int page)
        {
            int totalCount = await _readRepository.Table.CountAsync();
            IQueryable<Product> query;
            if(size == -1 || page == -1) {

                query = _readRepository.GetAll(false).Include(p => p.Translations)
                                                      .Include(p => p.Category);
            }
            else
            {
                query = _readRepository.GetAll(false).Include(p => p.Translations)
                                                     .Include(p => p.Category)
                                                     .Skip(size * page).Take(size);
            }

            List<Product> products = await query.ToListAsync();

            List<GetProductDTO> result = new List<GetProductDTO>();

            products.ForEach(p =>
            {
                // ProductTranslation
                List<GetProductTranslationDTO> getProductTranslationDTOs= new List<GetProductTranslationDTO>();

                p.Translations.ForEach(pt =>
                {
                    getProductTranslationDTOs.Add(new()
                    {
                        Name= pt.Name,
                        TranslationCode=pt.TranslationCode,
                        Description = pt.Description
                    });

                });

                result.Add(new GetProductDTO()
                {
                    Id = p.Id.ToString(),
                    CategoryId = p.Category.Id.ToString(),
                    IsActive = p.IsActive,
                    Price = p.Price,
                    Translation = getProductTranslationDTOs,
                    TotalCount = totalCount
                });

            });


            return result;

        }
        public async Task<GetProductDTO> GetProductByIdAsync(string id)
        {
            Product? product = await _readRepository.Table
                                                    .Include(p => p.Translations)
                                                    .Include(p => p.Category)
                                                    .FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));

            if (product == null)
                throw new ProductNotFoundException(ProductNotFoundException.Message);


            // ProductTranslation
            List<GetProductTranslationDTO> getProductTranslationDTOs = new List<GetProductTranslationDTO>();

            product.Translations.ForEach(pt =>
            {
                getProductTranslationDTOs.Add(new()
                {
                    Name = pt.Name,
                    TranslationCode = pt.TranslationCode,
                    Description = pt.Description
                });

            });

            return new()
            {
                Id = product.Id.ToString(),
                CategoryId = product.Category.Id.ToString(),
                IsActive = product.IsActive,
                Price = product.Price,
                TotalCount = 1,
                Translation = getProductTranslationDTOs
            };

        }

        public async Task<GetProductImageDTO> GetProductImagesAsync(string productId)
        {
            Product? product = await _readRepository.Table.Include(p => p.ImageFiles)
                                                          .FirstOrDefaultAsync(p => p.Id == Guid.Parse(productId));


            List<ProductImageDTO> productImageDTOs = new List<ProductImageDTO>();

            product.ImageFiles.ToList().ForEach(pimage =>
            {
                productImageDTOs.Add(new()
                {
                    ImageId = pimage.Id.ToString(),
                    FileName = pimage.FileName,
                    PathOrContainer = pimage.Path


                });
            });

            return new()
            {
                ProductId = product.Id.ToString(),
                ProductImageDTOs = productImageDTOs
            };
            
        }

        public async Task UpdateProductAsync(UpdateProductDTO updateProductDTO)
        {
            Product? product = await _readRepository.Table.Include(p =>p.Translations)
                                                         .FirstOrDefaultAsync(p => p.Id == Guid.Parse(updateProductDTO.Id));
            if (product == null)
                throw new ProductNotFoundException();

            product.Price = updateProductDTO.Price;
            product.IsActive = updateProductDTO.IsActive;

            product.Translations.ForEach(pt =>
            {
                if(pt.TranslationCode == updateProductDTO.TranslationCode)
                {
                    pt.Description = updateProductDTO.Description;
                    pt.Name = updateProductDTO.Name;
                }
            });

            _ = await _writeRepository.SaveAsync();

        }

        public async Task UpdateProductTranslationAsync(CreateProductTranslationDTO productTranslationDTO)
        {
            Product? product = await _readRepository.Table.Include(p => p.Translations)
                                                        .FirstOrDefaultAsync(p => p.Id == Guid.Parse(productTranslationDTO.ProductId));
            if (product == null)
                throw new ProductNotFoundException();

            product.Translations.ForEach(pt =>
            {
                if(pt.TranslationCode == productTranslationDTO.TranslationCode)
                {
                    pt.Description = productTranslationDTO.Description;
                    pt.Name = productTranslationDTO.Name;
                }
            });

            _ = await _readRepository.SaveAsync();
        }
    }
}
