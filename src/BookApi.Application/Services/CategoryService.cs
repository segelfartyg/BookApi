using System.Text.Json;
using System.Text.Json.Serialization;
using AutoMapper;
using BookApi.Application.Contracts.Dto;
using BookApi.Application.Interfaces;
using BookApi.EntityFrameworkCore.Interfaces;
using BookApi.EntityFrameworkCore.Model;
using StackExchange.Redis;

namespace BookApi.Application;

public class CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : ICategoryService
{
    public async Task<GetAllCategoriesResponseDto> GetAllCategoriesAsync()
    {

        var result = new GetAllCategoriesResponseDto { };

        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("BookApiRedis:6379");
        IDatabase db = redis.GetDatabase();

       var cacheRes = db.StringGet("ALL_CATEGORIES_CACHE_KEY");

        if (cacheRes != RedisValue.Null)
        {
            result = JsonSerializer.Deserialize<GetAllCategoriesResponseDto>(cacheRes.ToString());
            return result!;
        }

        var categoryList = categoryRepository.GetList();

        List<CategoryDto> mapResult = mapper.Map<List<Category>, List<CategoryDto>>(categoryList);

        var embedded = mapResult.Where(c => c.ParentId == 0);
        result.Embedded.Categories = embedded.ToList();

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var json = JsonSerializer.Serialize(result, options);
        var cacheSetRes = db.StringSet("ALL_CATEGORIES_CACHE_KEY", json);

        return result;
    }

    public async Task<CategoryDto> AddCategoryAsync(PostCategoryRequestDto category)
    {
        var cat = new Category()
        {
            Title = category.Title,
            Image = category.Image
        };

        var links = new Links()
        {
            Category = cat,
            CategoryId = cat.Id
        };

        // TODO: ADD NULL CHECKS
        links.Self = new LinkObject();
        links.Self.Href = category.Links.Self.Href;
        links.Self.Method = category.Links.Self.Method;
        links.Self.Title = category.Links.Self.Title;

        // TODO: ADD NULL CHECKS
        links.Books = new LinkObject();
        links.Books.Href = category.Links.Books.Href;
        links.Books.Method = category.Links.Books.Method;
        links.Books.Title = category.Links.Books.Title;

        // TODO: ADD NULL CHECKS
        links.DynamicContent = new LinkObject();
        links.DynamicContent.Href = category.Links.DynamicContent.Href;
        links.DynamicContent.Method = category.Links.DynamicContent.Method;
        links.DynamicContent.Title = category.Links.DynamicContent.Title;

        cat.Links = links;
        cat.ParentId = category.ParentId;

        await categoryRepository.AddAsync(cat);

        var result = mapper.Map<Category, CategoryDto>(cat);
        return result;
    }


    public async Task<bool> ModifyCategoryAsync(PatchCategoryRequestDto category)
    {
        var cat = new Category()
        {
            Id = category.Id,
            Title = category.Title,
            Image = category.Image
        };

        var links = new Links()
        {
            Category = cat,
            CategoryId = cat.Id
        };

        // TODO: ADD NULL CHECKS
        links.Self = new LinkObject();
        links.Self.Href = category.Links.Self.Href;
        links.Self.Method = category.Links.Self.Method;
        links.Self.Title = category.Links.Self.Title;

        // TODO: ADD NULL CHECKS
        links.Books = new LinkObject();
        links.Books.Href = category.Links.Books.Href;
        links.Books.Method = category.Links.Books.Method;
        links.Books.Title = category.Links.Books.Title;

        // TODO: ADD NULL CHECKS
        links.DynamicContent = new LinkObject();
        links.DynamicContent.Href = category.Links.DynamicContent.Href;
        links.DynamicContent.Method = category.Links.DynamicContent.Method;
        links.DynamicContent.Title = category.Links.DynamicContent.Title;

        cat.Links = links;
        cat.ParentId = category.ParentId;

        return await categoryRepository.ModifyAsync(cat);
    }

    public Task<bool> DeleteCategoryAsync(int categoryId)
    {
        return categoryRepository.DeleteAsync(categoryId);
    }
}