using BookApi.EntityFrameworkCore.Model;

namespace BookApi.EntityFrameworkCore.Interfaces;

public interface ICategoryRepository
{
    public Task<List<Category>> GetListAsync();
    public Task<Category> AddAsync(Category category);
    public Task<bool> ModifyAsync(Category category);
    public Task<bool> DeleteAsync(int categoryId);
}