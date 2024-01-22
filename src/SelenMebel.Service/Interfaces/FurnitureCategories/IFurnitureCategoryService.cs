using SelenMebel.Domain.Configurations;
using SelenMebel.Service.DTOs.FurnitureCategories;

namespace SelenMebel.Service.Interfaces.FurnitureCategories;

public interface IFurnitureCategoryService
{
    Task<bool> RemoveAsync(long id);
    Task<FurnitureCategoryForResultDto> RetrieveByIdAsync(long id);
    Task<FurnitureCategoryForResultDto> CreateAsync(FurnitureCategoryForCreationDto dto);
    Task<FurnitureCategoryForResultDto> ModifyAsync(long id, FurnitureCategoryForUpdateDto dto);
    Task<IEnumerable<FurnitureCategoryForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
