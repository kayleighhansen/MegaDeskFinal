using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskFinal.Models;

namespace MegaDeskFinal.Data {


public class MegaDeskFinalContext : DbContext
{
    public MegaDeskFinalContext(DbContextOptions<MegaDeskFinalContext> options)
        : base(options)
    {
    }

    public DbSet<DeskQuote> DeskQuote { get; set; }

    public DbSet<Desk> Desk { get; set; }

    public DbSet<ShippingType> ShippingType { get; set; }

    public DbSet<DesktopMaterial> DesktopMaterial { get; set; }
}

}
