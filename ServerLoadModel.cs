namespace ServerLoadWriter
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ServerLoadModel : DbContext
    {
        public ServerLoadModel()
            : base("name=ServerLoadModel")
        {
        }

        public virtual DbSet<ServerLoad> ServerLoads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServerLoad>()
                .Property(e => e.DnsName)
                .IsUnicode(false);

            modelBuilder.Entity<ServerLoad>()
                .Property(e => e.CpuUtilization)
                .IsUnicode(false);

            modelBuilder.Entity<ServerLoad>()
                .Property(e => e.MemoryUtilization)
                .IsUnicode(false);
        }
    }
}
