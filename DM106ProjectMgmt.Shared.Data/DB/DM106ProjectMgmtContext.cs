using DM106ProjectMgmt.Shared.Data.Models;
using DM106ProjectMgmt.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Data.DB
{
    public class DM106ProjectMgmtContext : IdentityDbContext<AccessUser, AccessRole, int>
    {
        // DbSet para as entidades do banco de dados
        public DbSet<MachineDesign> MachineDesign { get; set; }
        public DbSet<JobTask> JobTask { get; set; }
        public DbSet<Components> Components { get; set; }
        public DbSet<Requirement> Requirement { get; set; }

        // Connection string para o banco de dados
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjectMgmt_DB_V1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        // Configuração do DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

        // Relacionamento Muitos-para-Muitos entre MachineDesign e Components
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MachineDesign>()
                .HasMany(c => c.Components)
                .WithMany(d => d.MachineDesign);
        }
    }
}