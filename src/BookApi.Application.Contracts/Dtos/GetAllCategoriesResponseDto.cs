
using System.Text.Json.Serialization;

namespace BookApi.Application.Contracts.Dto;

public class GetAllCategoriesResponseDto
{
    [JsonPropertyName("_links")]
    public ApiLinksDto ApiLinks {get;set;} = new ApiLinksDto();
    [JsonPropertyName("_embedded")]
    public EmbeddedDto Embedded {get;set;} = new EmbeddedDto();
}