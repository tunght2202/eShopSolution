using eShopSolution.ViewModels.Catelog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catelog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
