using BookApi.EntityFrameworkCore.Interfaces;
using BookApi.EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookApi.EntityFrameworkCore.Data;

public class CategoryRepository(CategoryContext context) : ICategoryRepository
{
    public async Task<Category> AddAsync(Category category)
    {
        await context.Categories.AddAsync(category);
        await context.SaveChangesAsync();

        return category;
    }

    public async Task<bool> DeleteAsync(int categoryId)
    {
        var category = context.Categories.FirstOrDefault(c => c.Id == categoryId);
        if(category != null)
        {
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return true;
        }  
        return false;
    }

    // TODO: add filtering / limit request size. When handling larger amounts of data this is not good
    public async Task<List<Category>> GetListAsync()
    {

        var categories = await context.Categories
        .Include(x => x.Links).ThenInclude(y => y.Self)
        .Include(x => x.Links).ThenInclude(y => y.Books)
        .Include(x => x.Links).ThenInclude(y => y.DynamicContent).ToListAsync();

        return categories;
    }
}