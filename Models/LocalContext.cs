using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WisdomWaterServicePlatform.Models;

namespace WisdomWaterServicePlatform
{
    public class LocalContext : DbContext
    {
        public LocalContext(DbContextOptions<LocalContext> options) : base(options)
        {
        }
        public DbSet<Sypump> Sypump { get; set; }
    }
}
