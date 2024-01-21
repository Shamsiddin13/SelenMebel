using SelenMebel.Domain.Configurations;
using SelenMebel.Service.DTOs.Categories;
using SelenMebel.Service.Interfaces.Categories;

namespace SelenMebel.Service.Services.Categories;

public class CategoryService : ICategoryService
{
    public Task<CategoryForResultDto> CreateAsync(CategoryForCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryForResultDto> ModifyAsync(long id, CategoryForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CategoryForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryForResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
