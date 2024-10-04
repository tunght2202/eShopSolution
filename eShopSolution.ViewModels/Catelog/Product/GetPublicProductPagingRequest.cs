using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catelog.Product
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
