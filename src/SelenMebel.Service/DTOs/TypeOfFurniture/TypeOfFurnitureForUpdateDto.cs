using Microsoft.AspNetCore.Http;
using SelenMebel.Domain.Entities;

namespace SelenMebel.Service.DTOs.TypeOfFurniture;

public class TypeOfFurnitureForUpdateDto
{
    public string Name { get; set; }
    public IFormFile Image { get; set; }
    public long FurnitureId { get; set; }
}
