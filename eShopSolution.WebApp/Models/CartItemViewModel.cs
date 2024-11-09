﻿namespace eShopSolution.WebApp.Models
{
    public class CartItemViewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }
    }
}