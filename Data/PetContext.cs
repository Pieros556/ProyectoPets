using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoPets.Models;

namespace ProyectoPets.Data
{
    public class PetContext: IdentityDbContext
    {
        public DbSet<Publicacion> Publicaciones { get; set; }

        public PetContext(DbContextOptions<PetContext> options) : base(options) { }

    }
}