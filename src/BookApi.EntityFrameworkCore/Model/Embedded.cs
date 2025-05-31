namespace BookApi.EntityFrameworkCore.Model;

public class Embedded
{
    public int Id {get;set;}
    public List<Category>? Children {get;set;}
    public required Category Category {get;set;}
    public required int CategoryId {get;set;}
}