using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace TrocaoOleoAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Company, CompanyDto>()
            //    .ForCtorParam("FullAddress",
            //        opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
            
            CreateMap<Company, CompanyDto>();
            CreateMap<CreditCardBrand, CreditCardBrandDto>();
            CreateMap<ProductManufacturer, ProductManufacturerDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<CompanyForCreationDto, Company>();
            CreateMap<ProductManufacturerForCreationDto, ProductManufacturer>();
            CreateMap<ProductForCreationDto, Product>();
        }
    }
}
