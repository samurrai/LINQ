using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Car : Entity
    {
        public string Name { get; set; }
        public virtual Mark Mark { get; set; }
        public string Color { get; set; }
    }
}
