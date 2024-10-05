
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExamenParcial.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ExamenParcial.Models.Transacciones> DataTransacciones { get; set; }
    public DbSet<ExamenParcial.Models.HistorialConversiones> DataHistorial { get; set; }

}
