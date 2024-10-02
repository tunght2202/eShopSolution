using eShopSolution.Application.Catelog.Products.Dtos;
using eShopSolution.ViewModels.Catelog.Common;
using eShopSolution.ViewModels.Catelog.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catelog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategory(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
