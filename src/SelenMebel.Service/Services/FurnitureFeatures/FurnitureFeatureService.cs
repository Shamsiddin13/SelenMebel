using SelenMebel.Domain.Configurations;
using SelenMebel.Service.DTOs.FurnitureFeature;
using SelenMebel.Service.Interfaces.FurnitureFeatures;

namespace SelenMebel.Service.Services.FurnitureFeatures;

public class FurnitureFeatureService : IFurnitureFeatureService
{
    public Task<FurnitureFeatureForResultDto> CreateAsync(FurnitureFeatureForCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<FurnitureFeatureForResultDto> ModifyAsync(long id, FurnitureFeatureForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FurnitureFeatureForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<FurnitureFeatureForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
