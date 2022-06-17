using AutoMapper;
using SampleECommerce.Application.DTOs;
using SampleECommerce.Application.DTOs.Item;

using SampleECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleECommerce.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
     

            CreateMap<Item, ItemDto>().ReverseMap();

        }
    }
}
