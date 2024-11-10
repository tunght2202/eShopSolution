using eShopSolution.ViewModels.Catelog.Categories;
using eShopSolution.ViewModels.Catelog.Product;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
        Task<PagedResult<CategoryPageVm>> GetPagings(GetManageCategoryPagingRequest request);
        Task<bool> CreateCategory(CategoryCreateRequest request);
        Task<CategoryPageVm> GetById(int id, string languageId);
        Task<bool> DeleteCategory(int id);
    }
}
