#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrophyTest.Models;

namespace TrophyTest.Data
{
    public class TrophyTestContext : DbContext
    {
        public TrophyTestContext (DbContextOptions<TrophyTestContext> options)
            : base(options)
        {
        }

        public DbSet<TrophyTest.Models.Trophy> Trophy { get; set; }
    }
}
