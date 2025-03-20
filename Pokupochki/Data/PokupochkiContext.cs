using Microsoft.EntityFrameworkCore;
using Pokupochki.Models;

namespace Pokupochki.Data;

public class PokupochkiContext : DbContext
{
    public PokupochkiContext(DbContextOptions<PokupochkiContext> options) : base(options)
    {
        
    }
    
    public DbSet<Expence> Expences { get; set; } = null!;
}