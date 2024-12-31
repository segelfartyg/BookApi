namespace BookApi.Application.Contracts.Dto;

public class PatchCategoryRequestDto
{
    public required int Id {get;set;}
    public required string Title {get;set;}
    public required Uri Image {get;set;}
    public required LinksDto Links {get;set;}
    public int? ParentId {get;set;}
}