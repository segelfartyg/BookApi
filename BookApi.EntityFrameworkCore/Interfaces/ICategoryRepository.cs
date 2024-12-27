using BookApi.EntityFrameworkCore.Model;

namespace BookApi.EntityFrameworkCore.Interfaces;

public interface ICategoryRepository
{
    public Task<List<Category>> GetListAsync();
}