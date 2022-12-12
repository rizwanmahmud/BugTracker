using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext (DbContextOptions<BugTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<BugTracker.Models.Bug> Bug { get; set; } = default!;

        public DbSet<BugTracker.Models.Person> Person { get; set; }
    }
}
