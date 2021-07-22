using AluraFlix.Domain;
using AluraFlix.EFPersistence.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.EFPersistence.Context
{
    public class AluraFlixDbContext
        : DbContext
    {
        public AluraFlixDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Video>(new VideoConfiguration());
        }

    }
}
