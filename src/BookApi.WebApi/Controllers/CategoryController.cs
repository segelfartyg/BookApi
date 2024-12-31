using System.IO.Compression;
using AutoMapper;
using BookApi.Application.Contracts.Dto;
using BookApi.Application.Interfaces;
using BookApi.EntityFrameworkCore.Data;
using BookApi.EntityFrameworkCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Controllers;

[Route("/api/v1/[controller]")]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{

    /// <summary>
    /// Retrieves all categories, including child categories, present in the system.
    /// </summary>
    /// <returns></returns>
    [HttpGet("all")]
    public ActionResult<List<CategoryDto>> GetAllCategories()
    {
        // TODO: Check cache
        var result = categoryService.GetAllCategoriesAsync();
        return Ok(result);
    }

    /// <summary>
    /// Adds a new category, parentId is optional, making it possible to add child elements by specifying its parent.
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    [HttpPost("")]
    public async Task<ActionResult<List<CategoryDto>>> PostCategory([FromBody] PostCategoryRequestDto category)
    {   
        var result = await categoryService.AddCategoryAsync(category);
        return Ok(result);
    }

    /// <summary>
    /// Deletes a category based on id, returns notfound if not present
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    [HttpDelete("{categoryId}")]
     public async Task<ActionResult<List<CategoryDto>>> DeleteCategory([FromRoute] int categoryId)
    {

        var result = await categoryService.DeleteCategoryAsync(categoryId);
        return result ? Ok("category deleted") : NotFound("no category present");

    }
}