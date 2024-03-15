using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazy.Models
{
    public class LoginClass
    {
        public virtual string Login { get; set; }
        public virtual string Haslo { get; set; }
        public virtual bool CzyAdmin { get; set; }
    }
}
