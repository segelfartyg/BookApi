namespace BookApi.Application.Contracts.Dto;

public class PostCategoryRequestDto
{
    public required string Title {get;set;}
    public required Uri Image {get;set;}
    public required LinksDto Links {get;set;}
    public int? ParentId {get;set;}
}