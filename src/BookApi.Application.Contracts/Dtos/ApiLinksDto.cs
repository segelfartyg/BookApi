namespace BookApi.Application.Contracts.Dto;

public class ApiLinksDto
{
    public LinkObjectDto Self {get;set;} = new LinkObjectDto { Href=new Uri("https://api.bookbeat.com/api/categories"),  Method="GET" };
}