using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly_2._0.Dtos;
using Vidly_2._0.Models;

namespace Vidly_2._0.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<CustomerModel, CustomerDto>();
            Mapper.CreateMap<MovieModel, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<GenreModel, GenreDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, CustomerModel>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, MovieModel>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}