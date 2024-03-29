﻿using SelenMebel.Domain.Configurations;
using SelenMebel.Service.DTOs.Categories;
using SelenMebel.Service.DTOs.Furnitures;

namespace SelenMebel.Service.Interfaces.Furnitures;

public interface IFurnitureService
{
    Task<bool> RemoveAsync(long id);
    Task<FurnitureForResultDto> RetrieveByIdAsync(long id);
    Task<FurnitureForResultDto> RetrieveByUniqueIdAsync(long uniqueId);
    Task<FurnitureForResultDto> CreateAsync(FurnitureForCreationDto dto);
    Task<FurnitureForResultDto> ModifyAsync(long id, FurnitureForUpdateDto dto);
    Task<IEnumerable<FurnitureForResultDto>> RetrieveAllAsync(PaginationParams @params);
}
