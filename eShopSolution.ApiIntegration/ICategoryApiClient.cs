using eShopSolution.ViewModels.Catelog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
