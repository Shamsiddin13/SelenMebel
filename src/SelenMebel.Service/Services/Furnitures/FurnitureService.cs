using SelenMebel.Domain.Configurations;
using SelenMebel.Service.DTOs.Furnitures;
using SelenMebel.Service.Interfaces.Furnitures;

namespace SelenMebel.Service.Services.Furnitures;

public class FurnitureService : IFurnitureService
{
    public Task<FurnitureForResultDto> CreateAsync(FurnitureForCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<FurnitureForResultDto> ModifyAsync(long id, FurnitureForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FurnitureForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<FurnitureForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<FurnitureForResultDto> RetrieveByUniqueIdAsync(long uniqueId)
    {
        throw new NotImplementedException();
    }
}
