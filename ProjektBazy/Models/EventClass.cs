using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazy.Models
{
    internal class EventClass
    { 
        public virtual DateTime Data { get; set; }
        public virtual string Event { get; set; }
        public virtual string Godzina { get; set; }
        public virtual string Kto { get; set; }
    }
}
