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
public class CategoryController(CategoryContext context, ICategoryService categoryService) : ControllerBase
{
    [HttpGet("all")]
    public ActionResult<List<CategoryDto>> GetAllCategories()
    {
        // TODO: Check cache
        var result = categoryService.GetAllCategoriesAsync();
        return Ok(result);
    }

    [HttpPost("")]
    public async Task<ActionResult<List<CategoryDto>>> PostCategory([FromBody] PostCategoryRequestDto category)
    {   
        var result = await categoryService.AddCategoryAsync(category);
        return Ok(result);
    }

    [HttpDelete("{categoryId}")]
     public async Task<ActionResult<List<CategoryDto>>> DeleteCategory([FromRoute] int categoryId)
    {

        var result = await categoryService.DeleteCategoryAsync(categoryId);
        return result ? Ok("category deleted") : NotFound("no category present");

    }
}