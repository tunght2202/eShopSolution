using eShopSolution.ViewModels.Catelog.Product;
using eShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolution.WebApp
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVm> GetById(int id, string languageId);
    }
}
