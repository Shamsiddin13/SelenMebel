using SelenMebel.Domain.Commons;
using System.Net;

namespace SelenMebel.Domain.Entities;

public class Furniture : Auditable
{
    public string Name { get; set; }
    public long UniqueId { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }

    public long FurnitureFeatureId { get; set; }
    public FurnitureFeature FurnitureFeature { get; set; }
}
