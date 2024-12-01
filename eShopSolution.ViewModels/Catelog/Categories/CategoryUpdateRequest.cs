using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catelog.Categories
{
    public class CategoryUpdateRequest
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
    }
}
