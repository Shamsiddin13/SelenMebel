using SelenMebel.Domain.Commons;
using System.Dynamic;

namespace SelenMebel.Domain.Entities;

public class FurnitureFeature : Auditable
{
    public string ?Name { get; set; }
    public string ?Value { get; set; }
    
    public List<FurnitureFeature> FurnitureFeatures { get; set; }
}
