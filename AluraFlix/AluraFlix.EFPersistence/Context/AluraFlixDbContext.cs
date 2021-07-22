using AluraFlix.Domain;
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

    }
}
