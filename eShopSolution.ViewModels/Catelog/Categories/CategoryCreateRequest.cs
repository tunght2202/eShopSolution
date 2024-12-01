﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catelog.Categories
{
    public class CategoryCreateRequest
    {
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public Status Status { get; set; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }
    }
}
