using eShopSolution.Application.Catelog.Products.Dtos;
using eShopSolution.ViewModels.Catelog.Common;
using eShopSolution.ViewModels.Catelog.Product;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catelog.Products
{
    public interface IManagerProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdatePrice(int productId,  double newPrice);
        Task<bool> UpdateStock(int productId,  int addedQuantity);
        public Task AddViewcount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId,string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);

    }
}
