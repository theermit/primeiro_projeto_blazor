using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dominio.Models;

namespace infraestructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Regiao> Regioes { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }
}
