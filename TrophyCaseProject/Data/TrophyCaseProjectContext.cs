#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrophyCaseProject.Models;

namespace TrophyCaseProject.Data
{
    public class TrophyCaseProjectContext : DbContext
    {
        public TrophyCaseProjectContext (DbContextOptions<TrophyCaseProjectContext> options)
            : base(options)
        {
        }

        public DbSet<TrophyCaseProject.Models.Trophy> Trophy { get; set; }
    }
}
