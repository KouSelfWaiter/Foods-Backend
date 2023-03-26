using Applicaiton.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.ProductService
{
    public interface IProductService
    {
        Task<List<GetProductDTO>> GetAllProductsAsync(int size, int page);
        Task<GetProductDTO> GetProductByIdAsync(string id);
        Task CreateProductAsync(CreateProductDTO createProductDTO);
        Task DeleteProductAsync(string id);
        Task UpdateProductAsync(UpdateProductDTO updateProductDTO);
        Task CreateProductTranslationAsync(CreateProductTranslationDTO productTranslationDTO);
        Task UpdateProductTranslationAsync(CreateProductTranslationDTO productTranslationDTO);

    }
}
