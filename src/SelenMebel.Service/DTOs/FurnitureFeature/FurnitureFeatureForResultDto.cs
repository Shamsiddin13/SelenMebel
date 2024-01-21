namespace SelenMebel.Service.DTOs.FurnitureFeature;

public class FurnitureFeatureForResultDto
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }

    public List<FurnitureFeatureForResultDto> FurnitureFeatures { get; set; }
}
