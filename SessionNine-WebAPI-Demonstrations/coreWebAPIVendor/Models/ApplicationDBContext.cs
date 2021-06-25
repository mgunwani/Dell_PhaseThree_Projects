using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebAPIVendor.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDBContext(DbContextOptions options): base(options)
        { }
    }
}
