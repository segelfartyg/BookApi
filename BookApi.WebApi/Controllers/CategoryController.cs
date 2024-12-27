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
        var result = categoryService.GetAllCategoriesAsync();
        return Ok(result);
    }


    [HttpPost("add/{title}")]
    public async Task<ActionResult<List<CategoryDto>>> PostCategory([FromRoute] string title)
    {

        var cat = new Category()
        {
            Title = title,
            Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_12.png?format=png&quality=75&w=450")
        };

        var links = new Links()
        {
            Category = cat,
            CategoryId = cat.Id
        };

        links.Self = new LinkObject()
        {
            Href = new Uri("https://romance.se")
        };

        cat.Links = links;

        await context.Categories.AddAsync(cat);
        await context.SaveChangesAsync();

        return Ok("done");
    }

    [HttpPost("sub/add/{title}/{parentId}")]
    public async Task<ActionResult<List<CategoryDto>>> PostSubCategory([FromRoute] string title, [FromRoute] int parentId)
    {

        var cat = new Category()
        {
            Title = title,
            Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_12.png?format=png&quality=75&w=450")
        };

        var links = new Links()
        {
            Category = cat,
            CategoryId = cat.Id
        };



        links.Self = new LinkObject()
        {
            Href = new Uri("https://romance.se")
        };


        var parent = context.Categories.Single(c => c.Id == parentId);
        cat.Links = links;
        parent.Children?.Add(cat);

        await context.SaveChangesAsync();

        return Ok("done");
    }

    [HttpGet("setup")]
    public async Task<ActionResult<List<Category>>> Setup()
    {

        var cat = new Category()
        {
            Title = "Crime, Thrillers & Mystery",
            Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_12.png?format=png&quality=75&w=450")
        };

        var links = new Links()
        {
            Category = cat,
            CategoryId = cat.Id
        };

        var linksList = new List<LinkObject>(){

                   new LinkObject(){
                    Href = new Uri("https://google.se"),}
                   };

        links.Self = new LinkObject()
        {
            Href = new Uri("https://romance.se")
        };

        context.Categories.Add(cat);

        await context.SaveChangesAsync();

        return Ok("done");
    }

    [HttpGet("add/child/{catId}")]
    public async Task<ActionResult<List<Category>>> AddChild([FromQuery] int catId)
    {

        var cat = new Category()
        {
            Title = "Romance",
            Image = new Uri("https://prod-bb-images.akamaized.net/categories-covers/cat/img_category_12.png?format=png&quality=75&w=450")
        };

        var links = new Links()
        {
            Category = cat,
            CategoryId = cat.Id
        };

        links.Self = new LinkObject()
        {
            Href = new Uri("https://romance.se"),
            Method = "GET"
        };
        links.Books = new LinkObject()
        {
            Href = new Uri("https://romance.se"),
            Method = "GET"
        };
        links.DynamicContent = new LinkObject()
        {
            Href = new Uri("https://romance.se"),
            Method = "GET"
        };

        cat.Links = links;

        var parent = context.Categories.Single(c => c.Id == catId);
        parent.Children?.Add(cat);

        await context.SaveChangesAsync();

        return Ok("done");
    }
}