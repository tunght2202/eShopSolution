﻿using eShopSolution.ViewModels.Common;
using System.Collections.Generic;

namespace eShopSolution.ViewModels.Catelog.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
