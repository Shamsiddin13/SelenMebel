using Microsoft.AspNetCore.Http;

namespace SelenMebel.Service.DTOs.Furnitures;

public class FurnitureForUpdateDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public IFormFile Image { get; set; }
    public long FurnitureFeatureId { get; set; }
}
