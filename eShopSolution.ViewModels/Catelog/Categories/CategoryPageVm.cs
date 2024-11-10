using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catelog.Categories
{
    public class CategoryPageVm
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public string Name { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
    }
}
