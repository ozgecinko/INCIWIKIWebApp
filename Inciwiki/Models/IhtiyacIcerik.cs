using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inciwiki.Models
{
    public class IhtiyacIcerik
    {
        public int Id { get; set; }
        public int IcerikId { get; set; }
        public int IhtiyacId { get; set; }
        public Icerik Icerik { get; set; }
        public Ihtiyac Ihtiyac { get; set; }
    }
}
