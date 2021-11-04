using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

    public class MegaDeskFinalContext : DbContext
    {
        public MegaDeskFinalContext (DbContextOptions<MegaDeskFinalContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Desk> Desk { get; set; }
    }
