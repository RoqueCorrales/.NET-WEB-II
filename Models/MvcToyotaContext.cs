using Microsoft.EntityFrameworkCore;

namespace Proyecto_Web_ll.Models
{
    public class MvcToyotaContext : DbContext
    {
        public MvcToyotaContext (DbContextOptions<MvcToyotaContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto_Web_ll.Models.Cliente> Cliente{ get; set; }
        public DbSet<Proyecto_Web_ll.Models.Contacto> Contacto{ get; set; }
        public DbSet<Proyecto_Web_ll.Models.Reunion> Reunion{ get; set; }
        public DbSet<Proyecto_Web_ll.Models.Usuario> Usuario{ get; set; }
    }
}