using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace eShopSolution.ViewModels.Catelog.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }             
        public int PageSize { get; set; }             
    }
}
