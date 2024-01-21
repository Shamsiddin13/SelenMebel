using SelenMebel.Data.IRepositories;
using SelenMebel.Data.Repositories;
using SelenMebel.Domain.Entities;

namespace SelenMebel.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        
        services.AddScoped<IRepository<Furniture>, Repository<Furniture>>();    
        

        services.AddScoped<IRepository<TypeOfFurniture>, Repository<TypeOfFurniture>>();    
        

        services.AddScoped<IRepository<Category>, Repository<Category>>();    
        

        services.AddScoped<IRepository<FurnitureFeature>, Repository<FurnitureFeature>>();    
    }
}
