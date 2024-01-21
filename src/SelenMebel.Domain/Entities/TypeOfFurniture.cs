using SelenMebel.Domain.Commons;

namespace SelenMebel.Domain.Entities;

public class TypeOfFurniture : Auditable
{
    public string Name { get; set; }

    public long FurnitureId { get; set; }
    public Furniture Furniture { get; set; }
}
