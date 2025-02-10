using AdventureWorksDevContainer.Data.Entities;
using AdventureWorksDevContainer.Models;

using AutoMapper;

namespace AdventureWorksDevContainer.Data.Mappings;

public sealed class CustomerProfile : Profile
{
    public CustomerProfile() 
        : base(nameof(CustomerProfile))
    {
        AllowNullCollections = true;
        AllowNullDestinationValues = true;
        
        CreateMap<VIndividualCustomer, CustomerViewModel>()
            .ForMember(dest => dest.AddressLine1, opt => opt.MapFrom(src => src.AddressLine1))
            .ForMember(dest => dest.AddressLine2, opt => opt.MapFrom(src => src.AddressLine2))
            .ForMember(dest => dest.AddressType, opt => opt.MapFrom(src => src.AddressType))
            .ForMember(dest => dest.BusinessEntityId, opt => opt.MapFrom(src => src.BusinessEntityId))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.CountryRegionName, opt => opt.MapFrom(src => src.CountryRegionName))
            .ForMember(dest => dest.Demographics, opt => opt.MapFrom(src => src.Demographics))
            .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.EmailAddress))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.PhoneNumberType, opt => opt.MapFrom(src => src.PhoneNumberType))
            .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
            .ForMember(dest => dest.StateProvinceName, opt => opt.MapFrom(src => src.StateProvinceName))
            .ForMember(dest => dest.Suffix, opt => opt.MapFrom(src => src.Suffix))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
    }
}
