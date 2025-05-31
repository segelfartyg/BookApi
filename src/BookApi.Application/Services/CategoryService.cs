using System.Text.Json;
using System.Text.Json.Serialization;
using AutoMapper;
using BookApi.Application.Contracts.Dto;
using BookApi.Application.Interfaces;
using BookApi.EntityFrameworkCore.Interfaces;
using BookApi.EntityFrameworkCore.Model;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace BookApi.Application;

/// <summary>
/// Category service, used to provide functionality for the controller to retrieve and manipulate categories
/// </summary>
/// <param name="categoryRepository"></param>
/// <param name="mapper"></param>
/// <param name="configuration"></param>
/// 
public class CategoryService(ICategoryRepository categoryRepository, IMapper mapper, IConfiguration configuration) : ICategoryService
{   

    // TODO: when more settings like this is needed, make use of options pattern instead. 
    public const int CACHE_TTL_IN_SECONDS = 20;

    /// <summary>
    /// Retrieves all Categories from db, caching the result
    /// </summary>
    /// <returns></returns>
    public async Task<GetAllCategoriesResponseDto> GetAllCategoriesAsync()
    {

        var result = new GetAllCategoriesResponseDto { };

        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis")!);
        IDatabase db = redis.GetDatabase();

       var cacheRes = db.StringGet("ALL_CATEGORIES_CACHE_KEY");

        if (cacheRes != RedisValue.Null)
        {
            result = JsonSerializer.Deserialize<GetAllCategoriesResponseDto>(cacheRes.ToString());
            return result!;
        }

        var categoryList = await categoryRepository.GetListAsync();

        List<CategoryDto> mapResult = mapper.Map<List<Category>, List<CategoryDto>>(categoryList);

        var embedded = mapResult.Where(c => c.ParentId == 0);
        result.Embedded.Categories = embedded.ToList();


        // TODO: when needed elsewhere, make cache service instead of doing this
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        TimeSpan timeSpan = TimeSpan.FromSeconds(CACHE_TTL_IN_SECONDS);
        var json = JsonSerializer.Serialize(result, options);

        var cacheSetRes = await db.StringSetAsync("ALL_CATEGORIES_CACHE_KEY", json, timeSpan);

        return result;
    }

    /// <summary>
    /// Adds a category to the repository 
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    public async Task<CategoryDto> AddCategoryAsync(PostCategoryRequestDto category)
    {
        // TODO: ADD MORE VALIDATION, DEPENDING ON BUSINESS RULES OF LINKOBJECTS
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

        links.Self = new LinkObject();

        if(category.Links.Self != null) 
        {
            links.Self.Href = category.Links.Self.Href;
            links.Self.Method = category.Links.Self.Method;
            links.Self.Title = category.Links.Self.Title;
        }
        
        links.Books = new LinkObject();
        if(category.Links.Books != null) {

            links.Books.Href = category.Links.Books.Href;
            links.Books.Method = category.Links.Books.Method;
            links.Books.Title = category.Links.Books.Title;
        }

        links.DynamicContent = new LinkObject();

        if(category.Links.DynamicContent != null){
            links.DynamicContent.Href = category.Links.DynamicContent.Href;
            links.DynamicContent.Method = category.Links.DynamicContent.Method;
            links.DynamicContent.Title = category.Links.DynamicContent.Title;
        }


        cat.Links = links;
        cat.ParentId = category.ParentId;

        await categoryRepository.AddAsync(cat);

        var result = mapper.Map<Category, CategoryDto>(cat);
        return result;
    }

    /// <summary>
    /// Takes in a category and modifies it
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    public async Task<bool> ModifyCategoryAsync(PatchCategoryRequestDto category)
    {
        // TODO: ADD MORE VALIDATION, DEPENDING ON BUSINESS RULES OF LINKOBJECTS
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

        links.Self = new LinkObject();

        if(category.Links.Self != null) 
        {
            links.Self.Href = category.Links.Self.Href;
            links.Self.Method = category.Links.Self.Method;
            links.Self.Title = category.Links.Self.Title;
        }
        
        links.Books = new LinkObject();
        if(category.Links.Books != null) {

            links.Books.Href = category.Links.Books.Href;
            links.Books.Method = category.Links.Books.Method;
            links.Books.Title = category.Links.Books.Title;
        }

        links.DynamicContent = new LinkObject();

        if(category.Links.DynamicContent != null){
            links.DynamicContent.Href = category.Links.DynamicContent.Href;
            links.DynamicContent.Method = category.Links.DynamicContent.Method;
            links.DynamicContent.Title = category.Links.DynamicContent.Title;
        }

        cat.Links = links;
        cat.ParentId = category.ParentId;

        return await categoryRepository.ModifyAsync(cat);
    }

    /// <summary>
    /// Deletes a category based on categoryId
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    public Task<bool> DeleteCategoryAsync(int categoryId)
    {
        return categoryRepository.DeleteAsync(categoryId);
    }
}