using SelenMebel.Domain.Commons;
using System.Reflection.Metadata.Ecma335;

namespace SelenMebel.Domain.Entities;

public class FurnitureCategory : Auditable
{
    public long FurnitureId { get; set; }
    public Furniture Furniture { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<FurnitureCategory> Categories { get; set; }
}
