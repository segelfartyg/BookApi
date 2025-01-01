using BookApi.EntityFrameworkCore.Model;

namespace BookApi.EntityFrameworkCore.Interfaces;

public interface ICategoryRepository
{
    // TODO: EXPLORE ASYNC HERE
    public List<Category> GetList();

    public Task<Category> AddAsync(Category category);
    public Task<bool> ModifyAsync(Category category);

    public Task<bool> DeleteAsync(int categoryId);
}