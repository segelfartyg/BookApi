using BookApi.EntityFrameworkCore.Interfaces;
using BookApi.EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookApi.EntityFrameworkCore.Data;

/// <summary>
/// Repository for accessing and manipulating Categories in the data layer
/// </summary>
/// <param name="context"></param>
public class CategoryRepository(CategoryContext context) : ICategoryRepository
{

    /// <summary>
    /// Adds a category to db
    /// </summary>
    /// <param name="category"></param>
    /// <returns>Category</returns>
    public async Task<Category> AddAsync(Category category)
    {
        await context.Categories.AddAsync(category);
        await context.SaveChangesAsync();

        return category;
    }

    /// <summary>
    /// Changes an existing Category in the db,
    /// </summary>
    /// <param name="category">The category itself containing the wished state of the category</param>
    /// <returns>boolean of the result</returns>
    public async Task<bool> ModifyAsync(Category category)
    {

        var categoryToBeUpdated = await context.Categories.FirstOrDefaultAsync(c => c.Id == category.Id);
        if(categoryToBeUpdated != null)
        {
            context.Entry(categoryToBeUpdated).CurrentValues.SetValues(category);
            await context.SaveChangesAsync();
            return true;
        } 

        return false;
    }

    /// <summary>
    /// Deletes an existing Category in the db with 
    /// </summary>
    /// <param name="categoryId">the id of the category</param>
    /// <returns>boolean of the result</returns>
    public async Task<bool> DeleteAsync(int categoryId)
    {
        var category = await context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
  
        if(category != null)
        {

            var children = context.Categories.Where(c => c.ParentId == category.Id);

            foreach (var child in children) {
                child.ParentId = null;
            }

            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return true;
        }  
        return false;
    }

    /// <summary>
    /// Get all Categories in the database
    /// </summary>
    /// <returns>a list of all the categories</returns>
    public async Task<List<Category>> GetListAsync()
    {   

        // TODO: add filtering / limit request size. When handling larger amounts of data this is not good
        var categories = await context.Categories
        .Include(x => x.Links).ThenInclude(y => y.Self)
        .Include(x => x.Links).ThenInclude(y => y.Books)
        .Include(x => x.Links).ThenInclude(y => y.DynamicContent).ToListAsync();

        return categories;
    }
    
}