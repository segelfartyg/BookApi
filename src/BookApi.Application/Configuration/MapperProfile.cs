using AutoMapper;
using BookApi.Application.Contracts.Dto;
using BookApi.EntityFrameworkCore.Model;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
            CreateMap<Category, CategoryDto>();
            CreateMap<Links, LinksDto>();
            CreateMap<LinkObject, LinkObjectDto>();
    }
}