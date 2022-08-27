using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Core.Entities;

namespace TSWebApp.Infrastructure.Data
{
    public class EventContext: IdentityDbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Comment> Comment { get; set; }

    }
}
