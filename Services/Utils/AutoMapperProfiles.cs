using AutoMapper;
using Dto.Request;
using Dto.Response;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Utils
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Customer, DtoCustomerResponse>()
                .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.BirthDate));
            CreateMap<DtoCustomerResponse, Customer>();
            CreateMap<DtoCustomerRequest, Customer>();
            CreateMap<Customer, DtoCustomerRequest> ();
            CreateMap<DtoCustomerDirections, Direction>();
            CreateMap<Direction, DtoCustomerDirections>();
        }
    }
}
