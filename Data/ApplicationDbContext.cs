using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClienteApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ClienteApp.Models.Cliente> Clientes { get; set; }
    }
}
