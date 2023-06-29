using Microsoft.EntityFrameworkCore;


namespace WebGIS.EfCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }

        public DbSet<Cestice> Cestice { get; set; }
        public DbSet<AnoCestice> AnoCestice { get; set; }
        public DbSet<CesticeZgrade> CesticeZgrade { get; set; }
        public DbSet<Identifikacije> Identifikacije { get; set; }
        public DbSet<KatastarskeOpcine> KatastarskeOpcine { get; set; }
        public DbSet<MedjeCestica> MedjeCestica { get; set; }
        public DbSet<NaciniUporabe> NaciniUporabe { get; set; }
    }
}
