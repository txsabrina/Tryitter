using Tryitter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Tryitter.Context
{
  public class AppDbContext : IdentityDbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base( options )
    {}

    public DbSet<Conta>? Contas { get; set; }
    public DbSet<Postagem>? Postagens { get; set; }
  }
}