using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie25.Models;

namespace RazorPagesMovie25.Data
{
    public class RazorPagesMovie25Context : DbContext
    {
        public RazorPagesMovie25Context (DbContextOptions<RazorPagesMovie25Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie25.Models.Movie> Movie { get; set; }
    }
}
