using AutoMapper;
using BookApi.Application.Contracts.Dto;
using BookApi.Application.Interfaces;
using BookApi.EntityFrameworkCore.Interfaces;
using BookApi.EntityFrameworkCore.Model;

namespace BookApi.Application;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{
    public async Task<GetAllCategoriesResponseDto> GetAllCategoriesAsync()
    {
        var result = new GetAllCategoriesResponseDto{};

        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Category, CategoryDto>();
            cfg.CreateMap<Links, LinksDto>();
            cfg.CreateMap<LinkObject, LinkObjectDto>();
        });

        var mapper = new Mapper(config);
        var categoryList = await categoryRepository.GetListAsync();


        List<CategoryDto> mapResult = mapper.Map<List<Category>, List<CategoryDto>>(categoryList);

        var embedded = mapResult.Where(c => c.ParentId == 0);
        result.Embedded.Categories = embedded.ToList();

        return result;
    }
}