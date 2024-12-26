namespace BookApi.Application.Contracts.Dto;

public class LinkObjectDto
{
    public int Id {get;set;}
    public  Uri? Href {get;set;}
    public string? Method {get;set;}
    public string? Title {get;set;} 
 
}