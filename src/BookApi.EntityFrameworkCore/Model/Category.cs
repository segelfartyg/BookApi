namespace BookApi.EntityFrameworkCore.Model;

public class Category
{
    public int Id {get;set;}
    public required Uri Image {get;set;}
    public required string Title {get;set;}
    public  Links Links {get;set;} = null!;
    public List<Category> Children {get;set;} = new List<Category>();
    public Category? Parent {get;set;}
    public int? ParentId {get;set;}
}