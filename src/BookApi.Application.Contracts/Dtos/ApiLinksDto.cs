namespace BookApi.Application.Contracts.Dto;

// TODO: store as other linkobjects, adapt entities to it
public class ApiLinksDto
{
    public LinkObjectDto Self {get;set;} = new LinkObjectDto { Href=new Uri("https://api.bookbeat.com/api/categories"),  Method="GET" };
}