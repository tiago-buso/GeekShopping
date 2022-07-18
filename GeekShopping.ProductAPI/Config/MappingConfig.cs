﻿using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // Source - Target

            CreateMap<ProductVO, Product>();
            CreateMap<Product, ProductVO>();
        }        
    }
}
