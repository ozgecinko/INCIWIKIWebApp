using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Models
{
    public class Icerik
    {
        public int Id { get; set; }
        public string IcerikAdi { get; set; }
        public string IcerikResmi { get; set; }
        public string Aciklamasi { get; set; }
        public int? Oylama { get; set; }
    }
}
