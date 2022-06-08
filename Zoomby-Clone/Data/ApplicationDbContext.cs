using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zoomby_Clone.Models.Master;
using Zoomby_Clone.Models.Transaction;

namespace Zoomby_Clone.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pic> Pic { get; set; }
        public DbSet<ZoomAccount> zoomAccount { get; set; }
        public DbSet<ZoomScheduler> zoomScheduler { get; set; }
    }
}

