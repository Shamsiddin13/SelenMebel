using SelenMebel.Domain.Configurations;
using SelenMebel.Service.DTOs.TypeOfFurniture;
using SelenMebel.Service.Interfaces.TypeOfFurnitures;

namespace SelenMebel.Service.Services.TypeOfFurniture;

public class TypeOfFurnitureService : ITypeOfFurnitureService
{
    public Task<TypeOfFurnitureForResultDto> CreateAsync(TypeOfFurnitureForCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<TypeOfFurnitureForResultDto> ModifyAsync(long id, TypeOfFurnitureForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TypeOfFurnitureForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<TypeOfFurnitureForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
