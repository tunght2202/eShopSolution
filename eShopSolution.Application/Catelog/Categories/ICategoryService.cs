using eShopSolution.ViewModels.Catelog.Categories;
using eShopSolution.ViewModels.Catelog.Product;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catelog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);
        Task<CategoryPageVm> GetById(string languageId, int id);
        Task<PagedResult<CategoryPageVm>> GetAllPaging(GetManageCategoryPagingRequest request);
        Task<int> Create(CategoryCreateRequest request);

    }
}
