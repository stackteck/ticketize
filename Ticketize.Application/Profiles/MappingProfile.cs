﻿using AutoMapper;
using Ticketize.Application.Features.Categories.Queries.GetCategoriesList;
using Ticketize.Application.Features.Categories.Queries.GetCategoriesListEventListVm;
using Ticketize.Application.Features.Events.Queries.GetEventDetail;
using Ticketize.Application.Features.Events.Queries.GetEventsList;
using Ticketize.Domain.Entities;

namespace Ticketize.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
