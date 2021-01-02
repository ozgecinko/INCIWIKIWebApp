using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Models
{
    public class Icerik
    {
        public int Id { get; set; }
        public string IcerikAdi { get; set; }
        public string Aciklamasi { get; set; }
        public string IcerikResmi { get; set; }
        public int? Puani { get; set; }
        public string Language { get; set; }
    }
}
