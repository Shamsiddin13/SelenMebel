using SelenMebel.Domain.Commons;

namespace SelenMebel.Domain.Entities;

public class Category : Auditable
{
    public string Name { get; set; }
    
    public long TypeOfFurnitureId { get; set; }
    public TypeOfFurniture TypeOfFurniture { get; set; }
}
