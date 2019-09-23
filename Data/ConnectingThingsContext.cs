using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConnectingThings.Models
{
    public class ConnectingThingsContext : DbContext
    {
        public ConnectingThingsContext (DbContextOptions<ConnectingThingsContext> options)
            : base(options)
        {
        }

        public DbSet<ConnectingThings.Models.Authorization> Authorization { get; set; }
    }
}
