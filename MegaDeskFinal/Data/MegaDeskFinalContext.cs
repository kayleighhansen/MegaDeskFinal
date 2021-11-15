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

    public DbSet<MegaDeskFinal.Models.DeskQuote> DeskQuote { get; set; }

    public DbSet<MegaDeskFinal.Models.Desk> Desk { get; set; }

    public DbSet<MegaDeskFinal.Models.ShippingType> ShippingType { get; set; }

    public DbSet<MegaDeskFinal.Models.DesktopMaterial> DesktopMaterial { get; set; }
}

}
