using BookApi.EntityFrameworkCore.Interfaces;
using BookApi.EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookApi.EntityFrameworkCore.Data;

public class CategoryRepository(CategoryContext context) : ICategoryRepository
{

    // TODO: add filtering / limit request size. When handling larger amounts of data this is not good
    public Task<List<Category>> GetListAsync()
    {

        var categories = context.Categories
        .Include(x => x.Links).ThenInclude(y => y.Self)
        .Include(x => x.Links).ThenInclude(y => y.Books)
        .Include(x => x.Links).ThenInclude(y => y.DynamicContent).ToListAsync();

        return categories;
    }
}