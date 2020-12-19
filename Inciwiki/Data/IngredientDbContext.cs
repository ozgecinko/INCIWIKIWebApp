using Inciwiki.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Data
{
    public class IngredientDbContext : DbContext
    {
        public IngredientDbContext(DbContextOptions<IngredientDbContext> options):base(options)
        {

        }

        public DbSet<Ingredient> Ingredient { get; set; }
    }
}
