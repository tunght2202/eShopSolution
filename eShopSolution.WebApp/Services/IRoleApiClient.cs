using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.WebApp
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}
