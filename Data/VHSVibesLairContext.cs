using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VHSVibesLair.Models;

namespace VHSVibesLair.Data
{
    public class VHSVibesLairContext : DbContext
    {
        public VHSVibesLairContext (DbContextOptions<VHSVibesLairContext> options)
            : base(options)
        {
        }

        public DbSet<VHSVibesLair.Models.Movie> Movie { get; set; } = default!;
    }
}
