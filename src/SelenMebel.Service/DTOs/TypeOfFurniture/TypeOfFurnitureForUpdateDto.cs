using SelenMebel.Domain.Entities;

namespace SelenMebel.Service.DTOs.TypeOfFurniture;

public class TypeOfFurnitureForUpdateDto
{
    public string Name { get; set; }
    public long FurnitureId { get; set; }
}
