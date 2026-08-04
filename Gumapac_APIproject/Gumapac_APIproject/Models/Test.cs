using System.Text.Json.Serialization;
namespace Gumapac_APIproject.Models;

public class CatBreedResponse
{
    public List<CatBreedAPI> Data { get; set; } = new();
}
public class CatBreedAPI
{
    public string Breed { get; set; } = "";
    public string Country { get; set; } = "";
    public string Origin { get; set; } = "";
    public string Coat { get; set; } = "";
    public string Pattern { get; set; } = "";
}

