using Microsoft.EntityFrameworkCore;

namespace tartine.Data;

public class PizzaService
{
    private readonly PizzaStoreContext _context;

    public PizzaService(PizzaStoreContext context)
    {
        _context = context;
    }

    public async Task<PizzaSpecial[]> GetPizzasAsync()
    {
        return await _context.Specials.ToArrayAsync();
    }
}