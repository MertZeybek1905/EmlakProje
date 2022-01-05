using EmlakProje.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmlakProje.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmlakDbContext(serviceProvider.GetRequiredService<DbContextOptions<EmlakDbContext>>()))
            {
                if (context.Bilgiler.Any())
                {
                    return;
                }
                List<KayıtBilgi> _kayıtBilgi = new List<KayıtBilgi>();
                //{
                //    new KayıtBilgi{CompanyName="Zeybek",UserName="mert",Password=12345},
                //     new KayıtBilgi{CompanyName="Erenler",UserName="eren",Password=12345},
                //};
                context.Bilgiler.AddRange(_kayıtBilgi);
                context.SaveChanges();
            }
        }
    }
}
