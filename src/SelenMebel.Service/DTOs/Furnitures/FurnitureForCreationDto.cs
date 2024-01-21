using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SelenMebel.Service.DTOs.Furnitures;

public class FurnitureForCreationDto
{
    [Required, MinLength(3)]
    public string Name { get; set; }
    
    public long UniqueId { get; set; }

    [Required]
    public decimal Price { get; set; }
    
    [Required]
    public IFormFile Image { get; set; }
    public long FurnitureFeatureId { get; set; }
}
