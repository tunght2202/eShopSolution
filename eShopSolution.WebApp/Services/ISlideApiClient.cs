﻿using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Services
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
