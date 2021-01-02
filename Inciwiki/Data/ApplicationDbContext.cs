using System;
using System.Collections.Generic;
using System.Text;
using Inciwiki.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inciwiki.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Icerik> Icerik { get; set; }
        public DbSet<Ihtiyac> Ihtiyac { get; set; }
        public DbSet<IhtiyacIcerik> IhtiyacIcerik { get; set; }
    }
}
