namespace BookApi.EntityFrameworkCore.Model;

public class LinkObject
{
    public int Id {get;set;}
    public Uri? Href {get;set;}
    public string? Method {get;set;}
    public string? Title {get;set;}
}