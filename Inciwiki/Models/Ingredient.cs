using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Rating { get; set; }
    }
}
