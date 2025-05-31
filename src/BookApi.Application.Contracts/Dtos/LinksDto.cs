using System.Text.Json.Serialization;
using BookApi.EntityFrameworkCore.Model;

namespace BookApi.Application.Contracts.Dto;

public class LinksDto
{
    [JsonIgnore]
    public int Id {get;set;}
    public LinkObjectDto? Self {get;set;}
    public LinkObjectDto? Books {get;set;}
    public LinkObjectDto? DynamicContent {get;set;}
}