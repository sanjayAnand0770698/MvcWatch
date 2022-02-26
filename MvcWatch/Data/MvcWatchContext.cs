using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWatch.Models;

namespace MvcWatch.Data
{
    public class MvcWatchContext : DbContext
    {
        public MvcWatchContext (DbContextOptions<MvcWatchContext> options)
            : base(options)
        {
        }

        public DbSet<MvcWatch.Models.Watch> Watch { get; set; }
    }
}
