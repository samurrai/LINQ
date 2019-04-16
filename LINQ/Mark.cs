using System.Collections.Generic;

namespace LINQ
{
    public class Mark : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}