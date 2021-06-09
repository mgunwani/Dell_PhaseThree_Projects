using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreDatabaseFirstApproachDemo.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GF33IH9;Database=TrainingDB;Integrated Security=true;");
        }
    }
}
