namespace BookApi.Application.Contracts.Dto;

public class CategoryDto
{
    public int Id {get;set;}
    public required Uri Image {get;set;}
    public required string Title {get;set;}
    public  LinksDto? Links {get;set;}
    public int ParentId {get;set;}
    public List<CategoryDto> Children {get;set;} = new List<CategoryDto>();
}