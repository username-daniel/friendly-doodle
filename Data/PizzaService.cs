using Microsoft.EntityFrameworkCore;

namespace tartine.Data;

public class PizzaService
{
    private readonly IServiceScopeFactory _serviceScopeFactory;
    
           public PizzaService(IServiceScopeFactory serviceScopeFactory)
           {
               _serviceScopeFactory = serviceScopeFactory;
           }
    
           public async Task<PizzaSpecial[]> GetPizzasAsync()
           {
               using (var scope = _serviceScopeFactory.CreateScope())
               {
                   var context = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
                   return await context.Specials.ToArrayAsync();
               }
           }
}