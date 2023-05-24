﻿using AutoMapper;
using BusinessCape.DTOs.ImpositionPlate;
using BusinessCape.DTOs.Lineature;
using BusinessCape.DTOs.OrderProduction;
using BusinessCape.DTOs.Supply;
using BusinessCape.DTOs.SupplyCategory;
using DataCape.Models;

namespace BusinessCape.Mappers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            //=======================|SUPPLY CATEGORY|=======================//
            // POST OR CREATE //
            CreateMap<SupplyCategoryCreateDto, SupplyCategoryModel>();
            // PUT OR UPDATE //
            CreateMap<SupplyCategoryUpdateDto, SupplyCategoryModel>();

            //============================|SUPPLY|==========================//
            // POST OR CREATE //
            CreateMap<SupplyCreateDto, SupplyModel>();
            // PUT OR UPDATE //
            CreateMap<SupplyUpdateDto, SupplyModel>();

            //============================|ORDER PRODUCTION|==========================//
            // POST OR CREATE //
            CreateMap<OrderProductionCreateDto, OrderProductionModel>();
            // PUT OR UPDATE //
            CreateMap<OrderProductionUpdateDto, OrderProductionModel>();

            //============================|LINEATURE|==========================//
            // POST OR CREATE //
            CreateMap<LineatureCreateDto, LineatureModel>();
            // PUT OR UPDATE //
            CreateMap<LineatureUpdateDto, LineatureModel>();

            //============================|IMPOSITION PLATE|==========================//
            // POST OR CREATE //
            CreateMap<ImpositionPlateCreateDto, ImpositionPlateModel>();
            // PUT OR UPDATE //
            CreateMap<ImpositionPlateUpdateDto, ImpositionPlateModel>();
        }
    }
}
