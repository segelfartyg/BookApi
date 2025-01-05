namespace BookApi.Application.Contracts.Dto;

public class EmbeddedDto
{
    public List<CategoryDto> Categories {get;set;} = new List<CategoryDto>();  
}