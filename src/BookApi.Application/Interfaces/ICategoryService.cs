using BookApi.Application.Contracts.Dto;

namespace BookApi.Application.Interfaces;
public interface ICategoryService
{
    public Task<GetAllCategoriesResponseDto> GetAllCategoriesAsync();
    public Task<CategoryDto> AddCategoryAsync(PostCategoryRequestDto category);
    public Task<bool> ModifyCategoryAsync(PatchCategoryRequestDto category);
    public Task<bool> DeleteCategoryAsync(int categoryId);
}