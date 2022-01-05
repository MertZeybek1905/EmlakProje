using EmlakProje.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakProje.Data
{
    public class EmlakDbContext :DbContext
    {
        public EmlakDbContext( DbContextOptions<EmlakDbContext>options):base(options)
        {
                
        }
        public DbSet<KayıtBilgi> Bilgiler { get; set; }
        public DbSet<İlanlar> İlanBilgi { get; set; }
    }
}
