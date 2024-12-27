using BookApi.Application.Contracts.Dto;

namespace BookApi.Application.Interfaces;
public interface ICategoryService
{
    
    public Task<GetAllCategoriesResponseDto> GetAllCategoriesAsync();


}