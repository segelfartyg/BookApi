namespace BookApi.EntityFrameworkCore.Model;

public class Links
{
    public int Id {get;set;}
    public int? SelfId {get;set;}
    public LinkObject? Self {get;set;}
    public int? BooksId {get;set;}
    public LinkObject? Books {get;set;}
    public int? DynamicContentId {get;set;}
    public LinkObject? DynamicContent {get;set;}
    public Category? Category {get;set;}
    public int? CategoryId {get;set;}
}